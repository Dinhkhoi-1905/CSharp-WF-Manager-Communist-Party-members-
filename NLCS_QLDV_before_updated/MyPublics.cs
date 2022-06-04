using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLCS_QLDV
{
    class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMaCuocHop, strTenCuocHop, strQuyenSD, strMSPLL , strMSDV, strHoTen;
        public static DateTime NgayvaoDang;
        public static void ConnectDatabase()
        {
            string strConn = "Server = DESKTOP-2A5IS7F\\SQLEXPRESS; Database = QL_DangVien; Integrated Security = false; UID = B1910242; PWD = dinhkhoi";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConn;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception)
            {
            }
        }


        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName)
        {
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
        }
        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            bool blnRessult = false;
            try
            {
                string sqlSelect = "Select 1 From " + strTable + " Where " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows)
                    blnRessult = true;
                drReader.Close();
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
            return blnRessult;
        }
    }
}
