using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_mod.Models
{
    internal class User
    {//- Username
     //- Age
     //- Password Username, password property-ləri olmadan user obyekti yaratmaq olmaz.
        private string _password;
        public string Username { get; set; }
        public int Age // Age propery-i mənfi ola bilməz.
        {
            get {
                return 1;
               }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Age menfi ola bilmez");
                }

            }
        } 
        public string Password {
            get      //1. Boş ola bilməz
            {  return _password;
            } 
            set
            { bool a=false;
                if (value.Length>=0 )
                {
                    for (int i = 0; i <value.Length; i++)
                    {
                     a  = Char.IsWhiteSpace(value[0]);

                    }
                    if (a==true)
                    {
                        Console.WriteLine("kecersiz password");
                    }
                    else
                    {
                     
                       


                    }
                 



                }
                else
                {
                    Console.WriteLine("Uzunlugu 8 den kicik ola bilmez");
                }
            
            }
        }
        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }



        //2. Uzunluğu 8-dən kiçik ola bilməz
        //3. İçində ən az bir böyük hərf olmalıdır
        //4. İçində ən az bir rəqəm olmalıdır

        //Üçüncü və dördüncü şərti ayrı bir private methodda yazıb gəlib propertyinin setində istifadə etmək lazım
        private  void WhiteNUm(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                int d ;
                bool a = char.IsWhiteSpace(password[i]);
                bool b = char.IsNumber(password[i]);
                if (a == true && b == true)
                {
                    d = 1;
                
                    Console.WriteLine(d);
                }
                else
                {
                    d = 2;
                
                    Console.WriteLine(d);
                }

            }




        }
    }
   
} 
