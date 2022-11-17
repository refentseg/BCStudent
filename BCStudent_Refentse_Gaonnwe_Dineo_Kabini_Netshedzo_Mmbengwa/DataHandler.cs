using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    class DataHandler
    {
        string con = "Data Source=DESKTOP-DET2451;Initial Catalog=BCStudent;Integrated Security=True";


        //Add Student

        public void AddStudent(string StuNr, Image StdImg, string name, string surname, DateTime DOB, string Gender, string Addressline1, string Addressline2, string City, string Province, string PostalCode)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                       SqlCommand cmd = new SqlCommand("spAddStudent", connect);
                    
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StuNr", StuNr);

                        //Adding image
                        MemoryStream ms = new MemoryStream();
                        StdImg.Save(ms, ImageFormat.Jpeg);
                        byte[] photo_aray = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, photo_aray.Length);

                        cmd.Parameters.AddWithValue("@StdImg", photo_aray);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@AddressLine1", Addressline1);
                        cmd.Parameters.AddWithValue("@AddressLine2", Addressline2);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Province", Province);
                        cmd.Parameters.AddWithValue("@PostalCode", PostalCode);
                    connect.Open();
                        cmd.ExecuteNonQuery();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }

        }

        //Update Student
        public void UpdateStudent(string StuNr, Image StdImg, string name, string surname, DateTime DOB, string Gender, string Addressline1, string Addressline2, string City, string Province, string PostalCode)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spAddStudent", connect);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StuNr", StuNr);

                    //Adding image
                    MemoryStream ms = new MemoryStream();
                    StdImg.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);

                    cmd.Parameters.AddWithValue("@StdImg", photo_aray);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@AddressLine1", Addressline1);
                    cmd.Parameters.AddWithValue("@AddressLine2", Addressline2);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@Province", Province);
                    cmd.Parameters.AddWithValue("@PostalCode", PostalCode);
                    connect.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }

        }
        public DataTable DeleteStudent(int StuNr)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StuNr", StuNr);

                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        //Show All
        public DataTable GetStudents()
        {
            SqlConnection connect = new SqlConnection(con);
            SqlDataAdapter adapter = new SqlDataAdapter("spGETStudent", connect);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }
        //search
        public DataTable SearchData(int id)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StuNr", id);

                connect.Open();
                DataTable lb = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    lb.Load(dr);
                    return lb;
                }
            }
        }
        //search student moduls
        public DataTable SearchDataMod(int id)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudentModules", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StuNr", id);

                connect.Open();
                DataTable lb = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    lb.Load(dr);
                    return lb;
                }
            }
        }


       //ADD student to a Module
       public void AddStuModule(int sometext,string code)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spStudentModule", connect);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StuId", sometext);
                    cmd.Parameters.AddWithValue("@ModuleCode", code);
                    connect.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
        }


       
        public void AddModule(string modcode, string name, string description, string resources)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spAddaModule", connect);

                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@ModCode", modcode);
                    cmd.Parameters.AddWithValue("@ModName", name);
                    cmd.Parameters.AddWithValue("@ModDesc", description);
                    cmd.Parameters.AddWithValue("@ModRes", resources);
                    connect.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }

        }

        public void UpdateModule(string modcode, string name, string description, string resources)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateModule", connect);

                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@ModCode", modcode);
                    cmd.Parameters.AddWithValue("@ModName", name);
                    cmd.Parameters.AddWithValue("@ModDesc", description);
                    cmd.Parameters.AddWithValue("@ModRes", resources);
                    connect.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }

        }

        public DataTable DeleteModule(string modcode)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModCode", modcode);

                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public DataTable SearchModule(string modcode)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModCode", modcode);

                connect.Open();
                DataTable lb = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    lb.Load(dr);
                    return lb;
                }
            }
        }

        public DataTable GetModules()
        {
            SqlConnection connect = new SqlConnection(con);
            SqlDataAdapter adapter = new SqlDataAdapter("spGETModules", connect);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }


    }
}
