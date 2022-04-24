using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_no_4
{
    public class Dosen
    {
        //properties
        public string id { get; set; }
        public string Nama_Dosen { get; set; }
        public string NIK { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }

        //method 
        public void dosen()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Nama Dosen Pengampu: {0}", Nama_Dosen);
            Console.WriteLine("NIK: {0}", NIK);
            Console.WriteLine("Jenis Kelamin: {0}", Gender);
            Console.WriteLine("Pengampu Mata Kuliah {0}", Course);
        }
        
        public void attDosen()
        {
           
            string Nama = Console.ReadLine();
            string NIK = Console.ReadLine();
            
        }

        public void addCourse()
        {
            string course = Console.ReadLine();
        }
    }

    
    

}
