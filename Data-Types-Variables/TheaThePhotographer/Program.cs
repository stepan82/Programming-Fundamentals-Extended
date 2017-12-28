using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfPictures = ulong.Parse(Console.ReadLine());
           
            ulong filterTime = ulong.Parse(Console.ReadLine());
            
            ulong filterFactor = ulong.Parse(Console.ReadLine());
           
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            ulong totalFilterTime = numberOfPictures * filterTime;

            double filteredPics = numberOfPictures * (filterFactor / 100.0);

            double roundedFilteredPics = Math.Ceiling(filteredPics);

            ulong totalUploadTime = uploadTime * (ulong)roundedFilteredPics;

            ulong totalTime = totalFilterTime + totalUploadTime;

            TimeSpan ts = TimeSpan.FromSeconds(totalTime);
          
            Console.WriteLine($"{ts.Days}:{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}");
        }
    }
}
