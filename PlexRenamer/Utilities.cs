//#define USE_MADTVDB
#if USE_MADTVDB
using MadTVDB.Models;
#endif

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
        static public async Task<string> GetEpisodeTitle(string show, string season, string episode)
        {
            string title = "";

#if USE_MADTVDB
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

#endif
            return title;
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
