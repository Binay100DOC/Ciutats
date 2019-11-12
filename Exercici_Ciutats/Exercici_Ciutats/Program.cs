using System;

namespace Exercici_Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 1!!!!!!!!!!!!!!!!!");
            string ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;
            
            Console.WriteLine("Introdueix 1r ciutat: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Introdueix 2n ciutat: ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Introdueix 3r ciutat: ");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("Introdueix 4t ciutat: ");
            string userInput4 = Console.ReadLine();
            Console.WriteLine("Introdueix 5è ciutat: ");
            string userInput5 = Console.ReadLine();
            Console.WriteLine("Introdueix 6è ciutat: ");
            string userInput6 = Console.ReadLine();

            Console.WriteLine("\nLes 6 ciutats són: ");

            string[] nomsDeCiutats = { userInput1, userInput2, userInput3, userInput4, userInput5, userInput6 };
            for(int i = 0; i < nomsDeCiutats.Length; i++)
            {
                Console.WriteLine(nomsDeCiutats[i]);
            }
            Console.ReadLine();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 2!!!!!!!!!!!!!!!!!");

            string[] arrayCiutats = new string[nomsDeCiutats.Length];
            for(int i = 0; i < nomsDeCiutats.Length; i++)
            {
                arrayCiutats[i] = nomsDeCiutats[i];
            }

            Array.Sort(arrayCiutats);

            foreach(string i in arrayCiutats)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 3!!!!!!!!!!!!!!!!!");

            string[] ArrayCiutatsModificades = new string[arrayCiutats.Length];
            for(int i = 0; i<arrayCiutats.Length; i++)
            {
                ArrayCiutatsModificades[i] = arrayCiutats[i].Replace('a', '4');
            }
            foreach(string k in ArrayCiutatsModificades)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();

            Console.WriteLine("!!!!!!!!!!!!!!!!!Fase 4!!!!!!!!!!!!!!!!!");

            var firstCityArray = new char[nom.Length];
            var secondCityArray = new char[secondCity.Length];
            var thirdCityArray = new char[thirdCity.Length];
            var fourthCityArray = new char[fourthCity.Length];
            var fifthCityArray = new char[fifthCity.Length];
            var sixthCityArray = new char[sixthCity.Length];
        }
    }
}
