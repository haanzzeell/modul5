using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_41
{
   //class userService
    class userService {
        // deklarasi variable untuk class userService
        private string[,] data;
        private string email, password, roles = "";

        //constructor yang akan diinisialisasi dengan parameter email dan pass bertipe string
        public userService(string emails, string passwords)
        {
            //set email dan pass sesuai isi parameter
            email = emails;
            password = passwords;
            //set data dengan array 2 dimensi berisi email, pass, dan role user yang bisa login
            data = new string[2, 3] {
                {"hanaadilah@gmail.com", "12345", "superadmin" },
                {"gunawanprasetya@gmail.com", "12345", "user"  }
            };
        }

        // function login
        public void login()
        {
            // memanggil function checkCredentials dan disimpan dalam variable status, role
            var (status, role) = checkCredentials();
            // jika status sama dengan true
            if (status == true)
            {
                // maka akan menampilkan welcome role, dan email user yang login
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email);
            }
            else
            {
                // jika bernilai false akan menampilkan invalid login
                Console.WriteLine("\nInvalid Login");
            }
        }
        private (bool, string) checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    return (true, roles);
                }
            }
            return (false, roles);
        }
    }
}
