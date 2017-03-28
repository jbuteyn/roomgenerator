using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string response;
            do
            {
                Console.WriteLine("Please Enter Length");
                string roomLength = Console.ReadLine();
                float roomLengthFloat = float.Parse(roomLength);

                Console.WriteLine("Please Enter Width");
                string roomWidth = Console.ReadLine();
                float roomWidthFloat = float.Parse(roomWidth);

                float Area = roomWidthFloat * roomLengthFloat;
                float Perimeter = (roomWidthFloat * 2) + (roomLengthFloat * 2);


                Console.WriteLine("Room Area is:" + Area);
                Console.WriteLine("Room Perimeter is:" + Perimeter);

                Console.WriteLine("Do you wish to enter another room?(y)");
                response = Console.ReadLine();
            }
            while (response == "y");
            Console.WriteLine("Thanks for using room generator");
            
            
        }
    }
}
