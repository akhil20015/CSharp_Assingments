using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    internal class Assingment1
    {
        public void questions()
        {
            // 1) Program to display datetime in the format( 2023-06-27 13:30) 
            Console.WriteLine("Program to display datetime in the format( 2023-06-27 13:30)\n");
            
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("yyyy-mm-dd HH:mm"));


            // 2) Program to find the age of person
            Console.WriteLine("\nProgram to find the age of person\n");

            DateTime birth = Convert.ToDateTime(Console.ReadLine());

            int age = dt.Year - birth.Year;
            if(dt.Month < birth.Month || dt.Month == birth.Month && dt.Date < birth.Date)
            {
                --age;
            }
            Console.WriteLine(age + "\n");


            // 3) Program to disaply each character for a string
            Console.WriteLine("Program to disaply each character for a string\n");

            Console.WriteLine("enter a string");
            string name = Console.ReadLine();

            for(int i = 0;i<name.Length;i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();


            //4) Program to search for a given work in a string
            Console.WriteLine("Program to search for a given work in a string\n");

            Console.WriteLine("enter a word to be searched in the above string");
            string word = Console.ReadLine();

            Console.WriteLine($" Does {name} contain {word} ? \n" + name.Contains(word));


            //5 Program to insert some text in a fixed position

            Console.WriteLine("Program to insert some text in a fixed position\n");

            Console.WriteLine("enter a string to be inputed into the previous string");
            string addstring = Console.ReadLine();

            Console.WriteLine("enter the index to be inserted");
            int index = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine(name.Insert(index, addstring));



        }
    }
}
