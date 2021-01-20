
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE
{
    public class ReportFall : INotifyPropertyChanged
    {
        public int FallId { get; set; }
        private DateTime dateRep;
        

        [Key]
        [Column(Order = 1)]
        public DateTime DateRep {
            get { return dateRep; }
            set
            {
                dateRep = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("dateRep");
            }
        }
        private String nameReporter;
        [Key]
        [Column(Order = 2)]
        public String NameReporter {
            get { return nameReporter; }
            set
            {
                nameReporter = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("nameReporter");
            }
        }
        private String address;
        public String Address {
            get { return address; }
            set
            {
                address = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("address");
            }
        }
        private String city;
        public String City {
            get { return city; }
            set
            {
                city = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("city");
            }
        }
        private int boomsN;
        public int BoomsN {
            get { return boomsN; }
            set
            {
                boomsN = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("curRepFall");
            }
        }
        private int intensity;
        public int Intensity {
            get { return intensity; }
            set
            {
                intensity = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("intensity");
            }
        }
        //public double LongRep { get; set; }
        //public double LatRep { get; set; }

        private Coordinate coordinateR;

        public Coordinate CoordinateR
        {
            get { return coordinateR; }
            set { coordinateR = value; }
        }

        public ReportFall(int fallId, DateTime date, String nameReporter, String address, String city, int boomsN, int intensity, Coordinate coordinateR)
        {
            FallId = fallId;
            DateRep = date;
            NameReporter = nameReporter;
            Address = address;
            City = city;
            BoomsN = boomsN;
            Intensity = intensity;
            CoordinateR = coordinateR;
        }

        public ReportFall()
        {
            FallId = 0;
            DateRep = DateTime.Now;
            NameReporter = "";
            Address = "";
            BoomsN = 1;
            Intensity = 1;
            CoordinateR = new Coordinate(0, 0);
            City = "";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
