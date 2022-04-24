using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_no_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class dosen
            Dosen pengampu = new Dosen ();

            Console.Write("Nama Dosen Pengampu: \n");
            pengampu.Nama_Dosen = Console.ReadLine();

            Console.Write("NIK: \n");
            pengampu.NIK = Console.ReadLine();

            Console.Write("Mengampu Mata Kuliah: \n");
            pengampu.Course = Console.ReadLine();

            // mengeset nilai 
            pengampu.id = "2468\n";
            pengampu.Nama_Dosen = "Kamarudin, M.Kom\n";
            pengampu.NIK = "985643\n";
            pengampu.Gender = "Pria\n";
            pengampu.Course = "Pemrograman\n";

            //memanggil method 
            pengampu.dosen();
            pengampu.attDosen();
            pengampu.addCourse();

            Console.ReadKey();
        }
    }
}
