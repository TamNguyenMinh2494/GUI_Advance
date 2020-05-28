using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Student
    {
        public string Mssv { get; set; }
        public string Ten { get; set; }
        public string HoLot { get; set; }
        public string GioiTinh { get; set; }

        public Student()
        {
        }

        public Student(string mssv, string ten, string hoLot, string gioiTinh)
        {
            Mssv = mssv;
            Ten = ten;
            HoLot = hoLot;
            GioiTinh = gioiTinh;
        }
        public override string ToString()
        {
            return  "MSSV: " + this.Mssv + "\n"+
                    "Tên: " + this.Ten + "\n" +
                    "Họ Lót: " + this.HoLot + "\n" +
                    "Giới Tính: " + this.GioiTinh + "\n" +
                    "-------------------------------------" + "\n";
        }
    }
}
