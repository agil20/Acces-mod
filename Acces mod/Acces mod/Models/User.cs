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
        private int _age;
        public string Username { get; set; }
        public int Age // Age propery-i mənfi ola bilməz.
        {
            get {
                return _age;
               }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Age menfi ola bilmez");
                }
                _age= value;
            }
        } 
        public string Password {
            get      //1. Boş ola bilməz
            {  return _password;
            } 
            set
            {
                if (string.IsNullOrEmpty(value) == false && value.Length >= 8 == true && WhiteNUm(value)==true)
                {
                    _password= value;
                }
                else
                {
                    Console.WriteLine("Password duzgun qeyd olunmayb");
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
        private  bool WhiteNUm(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                bool d=false ;
                bool a = char.IsUpper(password[i]);
                bool b = char.IsNumber(password[i]);
                if (a == true && b == true)
                {
                    d = true; 
                
        
                }
                else
                {
                    d = false;
                
                 
                }
               return d;
            }
            return true;



        }
    }
   
} 
