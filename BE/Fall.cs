using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE
{
    public class Fall
    {
        [NotMapped]
        private static int numOfFall=1;

        public int FallId { get; set; }

        public String AddressFall { get; set; }
        private Coordinate coordinateF;
        public String CityFall { get; set; }
        public Coordinate CoordinateF
        {
            get { return coordinateF; }
            set { coordinateF = value; }
        }


        //public double LongFall { get; set; }
        //public double LatFall { get; set; }
        public DateTime DateFall { get; set; }

        // private string imageLocation;

        //public string ImageLocation
        //{
        //    get { return imageLocation; }
        //    set { imageLocation = value; }
        //}

        public string ImageLocation { get; set; }

        public Fall (int fallId, String addressFall,String city, Coordinate coordinateF, DateTime date, String imageLocation)
        {
            FallId = fallId;
            AddressFall = addressFall;
            CityFall = city;
            CoordinateF = coordinateF;
            DateFall = date;
            ImageLocation = imageLocation;
        }

        public Fall( String addressFall, String city, Coordinate coordinateF, DateTime date, String imageLocation)
        {
            numOfFall++;
            FallId = numOfFall;
            AddressFall = addressFall;
            CityFall = city;
            CoordinateF = coordinateF;
            DateFall = date;
            ImageLocation = imageLocation;
        }

        public Fall()
        {
            numOfFall++;
            FallId = numOfFall;
            AddressFall = "";
            CityFall = "";
            CoordinateF = new Coordinate(0, 0);
            DateFall = DateTime.Now;
            ImageLocation = "";
        }

    }
}
