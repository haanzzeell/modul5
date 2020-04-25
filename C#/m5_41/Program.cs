using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_41
{
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            // deklarasi variabel
            string email, password;

            Console.Write("Email : ");
            // membaca input user dan disimpan dalam variabel email
            email = Console.ReadLine();
            Console.Write("Password : ");
            // membaca input user dan disimpan dalam variabel password
            password = Console.ReadLine();

            // membuat object baru dengan variabel data dan menginisialisasi constructor userService
            // dengan isi parameter input email dan password
            userService data = new userService(email, password);
            // memanggil function login
            data.login();

            Console.ReadKey();
        }
    }
}