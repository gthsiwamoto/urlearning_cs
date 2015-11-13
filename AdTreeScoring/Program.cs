﻿using System;
using Scoring;
using AStar;

namespace Main
{
    class MainClass
    {
        static void Main(string[] args)
        {
            try
            {
                //ADTreeScoring.Execute(args);
                AStarLearning.Execute(args);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.In.ReadLine();
        }
    }
}
