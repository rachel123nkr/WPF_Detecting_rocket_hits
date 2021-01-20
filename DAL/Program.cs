using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProjectContext())
            {
                Coordinate coor = new Coordinate(5, 4);

                var f=new Fall();
                //var f = new ReportFall();// (600,new DateTime(1998,6,6),"name","street","city",2,2,3,3);
                Console.WriteLine("start");
                db.Falls.Add(f);
                Console.WriteLine("mid");
                db.SaveChanges();
                Console.WriteLine("finish");
                //updating
                //var result = db.Falls.SingleOrDefault(f1 => f1.FallId == 3);
                //if (result != null)
                //{
                //    Console.WriteLine("if_start");
                //    result.LatFall = 100;
                //    db.SaveChanges();
                //    Console.WriteLine("if_end");
                //}
            }




        }


    }
}

