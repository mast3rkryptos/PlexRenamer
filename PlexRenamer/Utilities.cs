using MadTVDB.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlexRenamer
{
    class Utilities
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        // Is successful if this function has a non-null non-empty result to put into the out-param title
        static public async Task<string> GetTVDBEpisodeTitle(string show, string season, string episode)
        {
            string title = "";

            if (show != null && show != "" && season != null && season != "" && episode != null && episode != "")
            {
                MadTVDB.MadTVDB madTVDB = new MadTVDB.MadTVDB("C4017334452A0FA1");
                TVDBSearchResponse searchResponse = await madTVDB.Search(show);
                for (int i = 0; i < searchResponse.searchResults.Count; i++)
                {
                    if (searchResponse.searchResults[i].language == "en")
                    {
                        TVDBSeriesResponse seriesResponse = await madTVDB.SeriesInformation(searchResponse.searchResults[i].seriesID);
                        for (int j = 0; j < seriesResponse.episodes.Count; j++)
                        {
                            if (seriesResponse.episodes[j].seasonNumber == Int32.Parse(season) && seriesResponse.episodes[j].episodeNumber == Int32.Parse(episode))
                            {
                                title = seriesResponse.episodes[j].episodeName;
                            }
                        }

                        // Only take the first English response from TVDB
                        break;
                    }
                }
            }

            return title;
        }

        static public void ParseNonPlexFilepath(string filepath, out string season)
        {

            string pattern = @"[seasonSEASON_]+(\d+)[discDISC_]+\d+";
            string containingFolder = Path.GetDirectoryName(filepath);

            MatchCollection matches = Regex.Matches(filepath, pattern);

            if (matches.Count > 0)
            {
                season = matches[0].Groups[1].Value;
            }
            else
            {
                season = "";
            }
        }

        // This reads the Plex name format and returns the parsed values
        // Movies: [root]\{movie name} ({movie year})\{movie name} ({movie year}).{ext}
        // Returns true if the filename matches the TV or Movie Plex format
        static public bool ParsePlexMovieFilename(string filepath, out string title, out string year)
        {
            string pattern = @"(.+) \(([0-9][0-9][0-9][0-9])\)";
            string filename = Path.GetFileNameWithoutExtension(filepath);

            MatchCollection matches = Regex.Matches(filename, pattern);

            if (matches.Count > 0)
            {
                title = matches[0].Groups[1].Value;
                year =  matches[0].Groups[2].Value;
            }
            else
            {
                title = "";
                year = "";
            }

            return matches.Count != 0;
        }

        // This reads the Plex name format and returns the parsed values
        // TV Shows: [root]\TV Shows\{show name}\Season ##\{show name} - s##e##[-e##] - {optional info}.{ext} 
        // Returns true if the filename matches the TV or Movie Plex format
        static public bool ParsePlexTVFilename(string filepath, out string show, out string season, out string startingEpisode, out string endingEpisode, out string optionalInfo)
        {
            string pattern = @"(.+) - s([0-9][0-9])e([0-9][0-9])(?:-e([0-9][0-9]))? - (.+)";
            string filename = Path.GetFileNameWithoutExtension(filepath);

            MatchCollection matches = Regex.Matches(filename, pattern);

            if (matches.Count > 0)
            {
                show =              matches[0].Groups[1].Value;
                season =            matches[0].Groups[2].Value;
                startingEpisode =   matches[0].Groups[3].Value;
                endingEpisode =     matches[0].Groups[4].Value;
                optionalInfo =      matches[0].Groups[5].Value;
                if (endingEpisode == "") endingEpisode = startingEpisode;
            }
            else
            {
                show = "";
                season = "";
                startingEpisode = "";
                endingEpisode = "";
                optionalInfo = "";
            }

            return matches.Count != 0;
        }

        static public ArrayList WalkDirectoryTree(System.IO.DirectoryInfo root, string[] extensionFilter = null)
        {
            ArrayList retFiles = new ArrayList();
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            foreach (string ef in extensionFilter)
            {
                // First, process all the files directly under this folder
                try
                {
                    files = root.GetFiles("*." + ef + "*");
                }
                // This is thrown if even one of the files requires permissions greater
                // than the application provides.
                catch (UnauthorizedAccessException e)
                {
                    // This code just writes out the message and continues to recurse.
                    // You may decide to do something different here. For example, you
                    // can try to elevate your privileges and access the file again.
                    log.Add(e.Message);
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }

                if (files != null)
                {
                    foreach (System.IO.FileInfo fi in files)
                    {
                        // In this example, we only access the existing FileInfo object. If we
                        // want to open, delete or modify the file, then
                        // a try-catch block is required here to handle the case
                        // where the file has been deleted since the call to TraverseTree().
                        //Console.WriteLine(fi.FullName);
                        retFiles.Add(fi.FullName);
                    }
                }
            }

            // Now find all the subdirectories under this directory.
            subDirs = root.GetDirectories();

            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                ArrayList subFiles = WalkDirectoryTree(dirInfo, extensionFilter);
                foreach (string sf in subFiles)
                {
                    retFiles.Add(sf);
                }

            }

            return retFiles;
        }
    }
}
