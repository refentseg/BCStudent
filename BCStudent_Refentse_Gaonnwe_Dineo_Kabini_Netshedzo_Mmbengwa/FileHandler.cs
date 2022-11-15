using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    class FileHandler
    {
        public void AddUser(string regUsername, string regPassword)
        {
            try
            {
                FileStream stream = new FileStream("userCredentials.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine("------------------------------------------------");
                writer.WriteLine(regUsername);
                writer.WriteLine(regPassword);
                writer.WriteLine("------------------------------------------------");
                writer.Close();
                stream.Close();
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show(error.Message);

            }
        }
        public string[] CheckUser()
        {
            FileStream stream = new FileStream("userCredentials.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string row = reader.ReadLine();
            string name = reader.ReadLine();
            string password = reader.ReadLine();
            string row2 = reader.ReadLine();
            reader.Close();
            string[] stored = { name, password};
            return stored;


        }
    }
}
