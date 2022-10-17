using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user= new phoneUser(new phoneOne_1());
            user.Usephone();
        }

        class phoneUser
        {
            private Iphone _phone;
            public phoneUser(Iphone phone)
            {
                _phone = phone;
            }
            public void Usephone()
            {
                _phone.send();
                _phone.Dail();
                _phone.Hang();
            }
        }

        interface Iphone
        {
            void Dail();
            void send();
            void Hang();
        }

        class phoneOne_1 : Iphone
        {
            public void Dail()
            {
                Console.WriteLine("one is dialing");
                Console.ReadKey();
            }

            public void Hang()
            {
                Console.WriteLine("one is haning");
                Console.ReadKey();
            }

            public void send()
            {
                Console.WriteLine("one is sending");
                Console.ReadKey();
            }
        }

        class phoneTwo_2 : Iphone
        {
            public void Dail()
            {
                Console.WriteLine("two is dialing");
                Console.ReadKey();
            }

            public void Hang()
            {
                Console.WriteLine("two is dialing");
                Console.ReadKey();
            }

            public void send()
            {
                Console.WriteLine("two is dialing");
                Console.ReadKey();
            }
        }
    }
}
