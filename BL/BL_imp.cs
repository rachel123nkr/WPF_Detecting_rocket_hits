using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Device.Location;
namespace BL
{
    public class BL_imp : IBL
    {
        Idal myDal;

        public BL_imp()
        {
            myDal = FactoryDal.get_dal();
        }

        public void AddFall(Fall newFall)
        {
            if (newFall.DateFall > DateTime.Now)
                throw new Exception("The date is not valid");
            if (newFall.CoordinateF==new Coordinate())
                throw new Exception("The address not valid");
            //צריך להכניס את הנקודות ציון
            myDal.AddFall(newFall);
        }

        public void AddReportFall(ReportFall newReportFall)
        {
            if (newReportFall.DateRep > DateTime.Now)
                throw new Exception("future date is not valid");
            if (newReportFall.BoomsN <= 0)
                throw new Exception("The number is not valid");
            var x = newReportFall.Intensity;
            if (newReportFall.Intensity < 1 || newReportFall.Intensity > 10)
                throw new Exception("The Intensity is not valid");
            //צריך להכניס את הנקודות ציון
            myDal.AddReportFall(newReportFall);
        }

        public void DelFall(Fall newReport)
        {
            throw new NotImplementedException();
        }

        public void DelReportFall(ReportFall newReport)
        {
            throw new NotImplementedException();
        }


        public void UpdateFall(Fall newFall)
        {
            if (newFall.DateFall > DateTime.Now)
                throw new Exception("The date is not valid");
            myDal.UpdateFall(newFall);
        }

        public void UpdateReportFall(ReportFall newReport)
        {
            if (newReport.DateRep > DateTime.Now)
                throw new Exception("The date is not valid");
            if (newReport.BoomsN <= 0)
                throw new Exception("The number is not valid");
            if (newReport.Intensity < 1 || newReport.Intensity > 10)
                throw new Exception("The Intensity is not valid");
            myDal.UpdateReportFall(newReport);
        }

       public List<Fall> FallAcordDate(DateTime date)
        {
            List<Fall> myList = new List<Fall>();
            var result = from item in myDal.ListFalls()
                         where item.DateFall.Date == date.Date
                         select item;
            foreach (var item in result)
            {
                myList.Add(item);
            }
            return myList;
        }
       public List<Fall> FallAcordCity(string city)
        {
            List<Fall> myList = new List<Fall>();
            var result = from item in myDal.ListFalls()
                         where item.CityFall == city////????
                         select item;
            foreach (var item in result)
            {
                myList.Add(item);
            }
            return myList;

        }

        public List<ReportFall> ReportFallAcordDate(DateTime date)
        {
            List<ReportFall> myList = new List<ReportFall>();
            var result = from item in myDal.ListReportFalls()
                         where item.DateRep.Date == date.Date
                         select item;
            foreach (var item in result)
            {
                myList.Add(item);
            }
            return myList;
        }
       public  List<ReportFall> ReportFallAcordCity(string city)
        {
            List<ReportFall> myList = new List<ReportFall>();
            var result = from item in myDal.ListReportFalls()
                         where item.City == city///???
                         select item;
            foreach (var item in result)
            {
                myList.Add(item);
            }
            return myList;
        }
        #region process e


        public double DistanceTo(GeoCoordinate baseCoordinates, GeoCoordinate targetCoordinates)
        {
            return 1000*DistanceTo(baseCoordinates, targetCoordinates, UnitOfLength.Kilometers);
        }

        public double DistanceTo(GeoCoordinate baseCoordinates, GeoCoordinate targetCoordinates, UnitOfLength unitOfLength)
        {
            var baseRad = Math.PI * baseCoordinates.Latitude / 180;
            var targetRad = Math.PI * targetCoordinates.Latitude / 180;
            var theta = baseCoordinates.Longitude - targetCoordinates.Longitude;
            var thetaRad = Math.PI * theta / 180;

            double dist =
                Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return unitOfLength.ConvertFromMiles(dist);
        }

        public List<Fall> FallList()
        {
            return myDal.ListFalls();
        }

        public List<ReportFall> ReportList()
        {
            return myDal.ListReportFalls();
        }

       
        public class UnitOfLength
        {
            public static UnitOfLength Kilometers = new UnitOfLength(1.609344);
            public static UnitOfLength NauticalMiles = new UnitOfLength(0.8684);
            public static UnitOfLength Miles = new UnitOfLength(1);

            private readonly double _fromMilesFactor;

            private UnitOfLength(double fromMilesFactor)
            {
                _fromMilesFactor = fromMilesFactor;
            }

            public double ConvertFromMiles(double input)
            {
                return input * _fromMilesFactor;
            }
        }
        #endregion

        


        public Coordinate GetCoordinate(string city, string Address)
        {
            if (city == ""|| Address=="")
                throw new Exception("The address not valid");
            return myDal.GetCoordinate(city, Address);
        }

        public Coordinate getImageCoordinate(string path)
        {
            if (path=="")
                throw new Exception("The address not valid");
            return myDal.GetImageCoordinate(path);
        }

        public double GetDistanceBetweenPoints(Coordinate coo1, Coordinate coo2)
        {
            return myDal.GetDistanceBetweenPoints(coo1, coo2);
        }

        public K_means GetKMeans()
        {
            return new K_means();
        }

        public ReportFall[] GetReportBetweenTime(DateTime dateRep)
        {
            return myDal.GetReportBetweenTime(dateRep);
        }

        public Fall GetFallById(int id)
        {
            return myDal.GetFall(id);
        }

        public void AddUser(User user)
        {
            if (user.EmailUser =="")
                throw new Exception("The email is not valid");

            if (user.PasswordUser == "")
                throw new Exception("The password is not valid");
            myDal.AddUser(user);
        }

        public User GetUser(string email, string password)
        {
           
                User u = myDal.GetUser(email, password);
                if (u == null)
                    throw new Exception("the email or the password is wrong");
                return u;
           
           
        }
    }
}
