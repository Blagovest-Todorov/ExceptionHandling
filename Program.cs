using System;

namespace _01.exceptionsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw exception 
            //expections is mechanism of handling errors, events;
            try
            {
                int a = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a number whole , number only as a input format"); ;
            }
            //exceptions are handeled with structures try{}-> catch(){}/

        }
    }
}
