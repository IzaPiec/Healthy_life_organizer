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

            u1.SetName("Alicja");
            u1.SetSurname("Nowak");
            u1.SetEmail("alicja.nowak@test.com");
            u1.SetNickname("Ala");

            u2.SetName("Krzysztof");
            u2.SetSurname("Nowak");
            u2.SetEmail("krzysztof.nowak@test.com");
            u2.SetNickname("Krzysiek");

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
                u1.GetName(),
                u1.GetSurname(),
                u1.GetEmail(),
                u1.GetNickname());
            Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}, Nickname: {3}",
                u2.GetName(),
                u2.GetSurname(),
                u2.GetEmail(),
                u2.GetNickname());

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
        private string Name;
        private string Surname;
        private string Email;
        private string Nickname;



        public User()
        {

        }
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public void SetSurname(string surname)
        {
            Name = surname;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetNickname()
        {
            return Nickname;
        }

        public void SetNickname(string nickname)
        {
            Nickname = nickname;
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
