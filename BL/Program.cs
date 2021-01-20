using BE;
using BL.Kmeans;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coordinate coo = new Geocoder().Geocode("Bnei Brak", "Shadal 2");
            //Console.WriteLine(coo.Latitude + " " + coo.Longitude);

            //Console.WriteLine(new Geocoder().GetDistanceBetweenPoints(coo, new Coordinate(32, 12)));
            //Console.ReadLine();

            double[][] long_lat = new double[][]
             {
                new double[] { 43.20, 32.45 },
                new double[] { 45,20 },
                new double[] { 43.20,32.5 }
             };

            double[] inten = new double[] { 2, 3, 5 };

            Coordinate[] result =new K_means().returnAvgPerGroup(long_lat,inten,3);
            int[] result2 = new K_means().returnPointPerGroup(long_lat, inten, 3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("___________");
            foreach (var item in result2)
            {
                    Console.WriteLine(item.ToString());
                
            }

            //FallData a=new FallData
            //{

            //    longA = 32.067081F,
            //    latA = 34.792976F,
            //    numOfBoom = 2,
            //    intensity = 3
            //};

            //new K_means().returnDistenceFromEstimate(a);
            Console.ReadLine();
        }
    }
}
