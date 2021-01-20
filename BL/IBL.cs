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
   public interface IBL
    {
        void AddReportFall(ReportFall newReport);
        void UpdateReportFall(ReportFall newReport);
        void DelReportFall(ReportFall newReport);


        void AddFall(Fall newReport);
        void UpdateFall(Fall newReport);
        void DelFall(Fall newReport);

        List<Fall> FallList();
        List<ReportFall> ReportList();
        List<Fall> FallAcordDate(DateTime date);
        List<ReportFall> ReportFallAcordCity(string city);
        List<ReportFall> ReportFallAcordDate(DateTime date);
        List<Fall> FallAcordCity(string city);
        double DistanceTo(GeoCoordinate baseCoordinates, GeoCoordinate targetCoordinates);

        Coordinate GetCoordinate(String city, String Address);
        Coordinate getImageCoordinate(String path);
        Fall GetFallById(int id);


        double GetDistanceBetweenPoints(Coordinate coo1, Coordinate coo2);

        K_means GetKMeans();

        ReportFall[] GetReportBetweenTime(DateTime dateRep);


        #region User
        void AddUser(User user);
        User GetUser(string email, string password);

        #endregion User
    }
}
