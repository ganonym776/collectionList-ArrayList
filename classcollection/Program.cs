using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "wely";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            Dosen dosen1 = new Dosen();
            dosen1.Nik = "0045";
            dosen1.NamaDosen = "Jhoni";

            ArrayList listdsn = new ArrayList();
            ArrayList listmhs = new ArrayList();
            listmhs.Add(mhs1);
            listmhs.Add(mhs2);
            listdsn.Add(dosen);
            listdsn.Add(dosen1);

            Console.WriteLine("Nim\tNama\tStatus\n===========================\n");
            foreach (Mahasiswa mhs in listmhs)
            {
                Console.WriteLine("{0}\t{1}\tMahasiswa", mhs.Nim, mhs.NamaMahasiswa);
                
            }

             foreach (Dosen dsn in listdsn)
            {
                Console.WriteLine("{0}\t{1}\tDosen", dsn.Nik, dsn.NamaDosen);
            }
            Console.ReadKey();

            /*ArrayList arrBilangan = new ArrayList();
            arrBilangan.Add(12);
            arrBilangan.Add(14);
            arrBilangan.Add(17);

            int bil = (int)arrBilangan[2];
            Console.WriteLine(bil);
            Console.WriteLine();

            foreach(int bilangan in arrBilangan)
            {
                Console.WriteLine(bilangan);
            }
            Console.ReadKey();
            */

            /*
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "wely";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);


            Console.WriteLine("Nim\tNama\n==================\n");
            foreach (Mahasiswa mhs in list){
                Console.WriteLine("{0}\t{1}", mhs.Nim, mhs.NamaMahasiswa);

            }
            Console.ReadKey();
            */

            /*
            List<string> lstNamaMhs = new List<string>();

            lstNamaMhs.Add("Erick");
            lstNamaMhs.Add("Wely");
            lstNamaMhs.Add("Rully");

            string namaMhs = lstNamaMhs[1];

            Console.WriteLine(namaMhs);
            Console.WriteLine();

            foreach(string nama in lstNamaMhs)
            {
                Console.WriteLine(nama);
            }
            Console.ReadKey();
            */
        }
    }
}
