using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection conn;
        // Backup
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QLNV(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLNV TO DISK = N'" + sDuongDan +
            sTen + "'";
            conn = DataProvider.Connect(); 
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }

        public static bool PhucHoi(string sDuongDan)
        {

            // Ví dụ : strCon = "server=.; Database=Master; uid =sa; pwd = 123456 ";
            // strPath: Đường dẫn đến file cần Restore
            // Ví dụ : strPath = "D:\Luu\TenCSDL(28_10_2010_8_28).bak)";

         
               string sTen = "\\QLNV(" + DateTime.Now.Day.ToString() + "_" +
               DateTime.Now.Month.ToString() + "_" +
               DateTime.Now.Year.ToString() + "_" +
               DateTime.Now.Hour.ToString() + "_" +
               DateTime.Now.Minute.ToString() + ").bak";
                string stRestore = "ALTER DATABASE [QLNV] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                stRestore += " RESTORE DATABASE [QLNV] FROM DISK = N'" + sDuongDan + "'";
                stRestore += " WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                stRestore += " ALTER DATABASE [QLNV] SET MULTI_USER ";
                conn = DataProvider.Connect();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(stRestore, conn);
                return kq;
          
          
        }

    }
}
