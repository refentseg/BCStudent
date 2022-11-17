using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    class Student:Module
    {
        private int id;
        private string surname;
        private DateTime dob;
        private string gender;
        private long phoneNo;
        private string address;
        private byte[] image;
        private int code;


        public Student(int id, string name, string surname, DateTime dob, string gender, long phoneNo, byte[] image, string address, int code) : base(name, name)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Dob = dob;
            this.Gender = gender;
            this.Image = image;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.Code = code;
        }

        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Address { get => address; set => address = value; }
        public int Code { get; private set; }
        public byte[] Image { get => image; set => image = value; }
    }
}
