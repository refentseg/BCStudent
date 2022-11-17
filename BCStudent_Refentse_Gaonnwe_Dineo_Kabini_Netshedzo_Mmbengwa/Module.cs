using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    class Module
    {

        private string modcode;
        private string name;
        private string description;
        private string resources;

        public Module(string modcode, string name)
        {
            this.modcode = modcode;
            this.name = name;
        }

        public Module(string modcode, string name, string description, string resources)
        {
            this.Modcode = modcode;
            this.Name = name;
            this.Description = description;
            this.Resources = resources;
        }

        public string Modcode { get => modcode; set => modcode = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Resources { get => resources; set => resources = value; }

        
    }
}
