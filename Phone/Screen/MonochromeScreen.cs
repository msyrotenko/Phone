﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class MonochromeScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Display Image {0}x{1} in {2} quality on monochrme screen", screenImage.Height,screenImage.Width, screenImage.Quality);
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Display Image {0}x{1} in {2} quality on monochrme screen with brightness={3}", screenImage.Height, screenImage.Width, screenImage.Quality, brightness);
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
    
}