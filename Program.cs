﻿using System;
using NLog.Web;
using System.IO;

namespace MovieLibrary_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\nlog.config";

            // create instance of Logger
            var logger = NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();
            logger.Info("Program started");
            
            string file = "movies.csv";
             // make sure movie file exists
            if (!File.Exists(file))
            {
                logger.Error("File does not exist: {File}", file);
            }
            else
            {
                string choice;
                do
                {
                    // display choices to user
                    Console.WriteLine("1) Add Movie");
                    Console.WriteLine("2) Display All Movies");
                    Console.WriteLine("Enter to quit");

                    // input selection
                    choice = Console.ReadLine();
                    logger.Info("User choice: {Choice}", choice);

                    if (choice == "1")
                    {
                        // Add Movie
                    }
                    else if (choice == "2")
                    {
                        // Display All Movies
                    }
                } while (choice == "1" || choice == "2");
            }



             logger.Info("Program ended");
        }
    }
}
