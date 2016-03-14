using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn5And6
{
    class Program
    {
        static void Main(string[] args)
        {

            User u1 = new User();
            User u2 = new User();

            UserM firstUser = new UserM();
            UserM secondUser = new UserM();

            u1.setName = "Alicja";
            u1.setSurname = "Nowak";
            u1.setEmail = "alicja.nowak@test.com";
            u1.setNickname = "Ala";

            u2.setName = "Krzysztof";
            u2.setSurname = "Nowak";
            u2.setEmail = "krzysztof.nowak@test.com";
            u2.setNickname = "Krzysiek";

            firstUser.Name = "Izabela";
            firstUser.Surname = "Piec";
            firstUser.Email = "izabela.piec@gmail.com";
            firstUser.Nickname = "Iza";

            secondUser.Name = "Anna";
            secondUser.Surname = "Kowalska";
            secondUser.Email = "anna.kowalska@gmail.com";
            secondUser.Nickname = "Ania";

            Console.WriteLine("***User Class***\n");
            Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}, Nickname: {3}",
                u1.setName,
                u1.setSurname,
                u1.setEmail,
                u1.setNickname);
            Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}, Nickname: {3}",
                u2.setName,
                u2.setSurname,
                u2.setEmail,
                u2.setNickname);

            Console.WriteLine("\n***UserM Class***\n");
            Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}, Nickname: {3}",
                firstUser.Name,
                firstUser.Surname,
                firstUser.Email,
                firstUser.Nickname);

            Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}, Nickname: {3}",
                secondUser.Name,
                secondUser.Surname,
                secondUser.Email,
                secondUser.Nickname);

            Console.ReadLine();
        }
    }


    class User
    {
        private string name;
        private string surname;
        private string email;
        private string nickname;



        public User()
        {

        }
        public string setName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string setSurname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string setEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string setNickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
    }


    class UserM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }

        public UserM()
        {

        }
    }
}
