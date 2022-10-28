using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Add this line that we can use SqlConnection or not
using System.Data;//Add this line that we can use DataTable or not

namespace ChuDe7_Nhom14_DuAn1
{
    public static class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMS, strSTT, strQuyenSD, strHoTen;


        //Trước khi xài hàm này phải tạo tài khoản TN207User trong sql server studio management
        //phải có CSDL QL_HoGiaDinh đã được restore và đã cấp quyền sở hữu cho CSDL
        //Tham số server truyền vào là tên server trên máy tính của bạn
        public static void ConnectDatabase(string server) {
            string strCon = "Server="+server+
                "; Database=QL_HoGiaDinh; Integrated Security = false; UID = TN207User; PWD = TN207User";
            Console.WriteLine(strCon);
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strCon;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception) {
                
            }
        }

        public static string EncodePass(string purePass) {
            string tmp1="", tmp2="";
            int i, n;
            n = purePass.Length;
            for (i = 0; i < n; i+=2) {
                tmp1 += purePass[i];
                if (n > i + 1) {
                    tmp2 += purePass[i + 1];
                }
            }

            return tmp1 + tmp2;

        }

        public static void OpenData(string strSelect, DataTable dataTB)
        {

            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                {
                    conMyConnection.Open();
                }
                SqlDataAdapter daAdapter = new SqlDataAdapter();
                daAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                SqlCommandBuilder cmb = new SqlCommandBuilder(daAdapter);
                daAdapter.Fill(dataTB);
                conMyConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        public static void OpenDataArgs(string strSelect, DataTable dataTB, SqlDataAdapter daAdapter) {

            try
            {
                if (conMyConnection.State == ConnectionState.Closed) {
                    conMyConnection.Open();
                }
                daAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                SqlCommandBuilder cmb = new SqlCommandBuilder(daAdapter);
                daAdapter.Fill(dataTB);
                conMyConnection.Close();
            }
            catch (Exception) { 
            
            }
        }

        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable) {
            bool res = false;
            try
            {
                string sqlSelect = "select 1 from " + strTable + " where " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                {
                    conMyConnection.Open();
                }
                SqlCommand cmd = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmd.ExecuteReader();
                if (drReader.HasRows)
                {
                    res = true;
                }
                drReader.Close();
                conMyConnection.Close();
            }
            catch (Exception) { 
            
            }

            return res;
        }


    }
}
