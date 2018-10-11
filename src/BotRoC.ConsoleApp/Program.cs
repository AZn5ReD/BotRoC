﻿using System;
using System.Drawing;
using log4net;

namespace BotRoC.ConsoleApp
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            AdbClass adbClass = new AdbClass();
            if (adbClass.StartServer() == 0)
            {
                adbClass.GetScreenSize();
                Point point = new Point(50, 700);
                adbClass.TouchScreen(point);

            }
            ImageUtil imageUtil = new ImageUtil();
            ImageFinder imageFinder = new ImageFinder();
            Bitmap needle = imageUtil.OpenImage("needle.jpg");
            Bitmap haystack = imageUtil.OpenImage("haystack.jpg");
            Console.WriteLine(imageFinder.searchBitmap(needle, haystack, 0.0));
            // Console.WriteLine(newPoint.X);
            // Console.WriteLine(newPoint.Y);
        }
    }
}
