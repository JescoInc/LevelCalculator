using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLevelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Needs to be changed to the directory it is in on downloader's pc
            // May end up setting parameters for program to auto generate file.
            const string data = "C:\\Users\\kohou\\Source\\Repos\\LevelCalculator\\RPGLevelCalculator\\RPGLevelCalculator\\GeneratedOutput.txt";

            double points = 0;
            double output = 0;
            int minlevel = 2; // first level to display
            int maxlevel = 100; // last level to display

            for (int lvl = 1; lvl <= maxlevel; lvl++)
            {
                points += Math.Floor(lvl + 300 * Math.Pow(2, lvl / 7));
                if (lvl >= minlevel)
                {
                    System.IO.File.AppendAllText(data, "Level " + (lvl) + " - " + output + " xp" + System.Environment.NewLine);
                }

                output = points / 4;
            }
        }
    }
}

