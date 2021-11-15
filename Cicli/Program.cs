using System;

namespace Cicli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Istanzio un oggetto della classe Persona Con il costruttore devo passare i due parametri 
             * aggiungendo un altro costruttore senza parametri, posso rimuoverli dalla creazione dell'oggetto nella classe di test */

            Persona persona = new Persona("Christian", "Romeo");

            Console.WriteLine(persona.Name);
            Console.WriteLine(persona.Lastname);

            persona.setHeigth(2);
            persona.setHeigth(1.80);
            persona.setHeigth();

            /*essendo un metodo di una classe non legata ad alcun oggetto, ma con solo attributi e metodi ausiliari (static/non legati ad un oggetto)
            * posso richiamarlo senza dover istanziare un oggetto */
            Ausiliari.setContatore();

            //do While (ask gender, only allowed F or M)
            string gender;
            do
            {
                Console.WriteLine("Inserisci il tuo genere (F/M)");
                gender = Console.ReadLine().ToUpper();
                if (gender != "F" && gender != "M")
                {
                    Console.WriteLine("Devi inserire F o M!");
                }
            } while (gender != "F" && gender != "M");

            Console.WriteLine($"Il tuo genere è {gender}");

            Console.WriteLine("Numbers from 1 to 10");
            //For (print numbers from 1 to 10)
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Numbers from 10 to 1");
            // For (print numbers from 10 to 1)
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Even numbers from 2 to 10");
            // Print even numbers from 2 to 10
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Even numbers from 2 to 10 /solution2");
            // Print even numbers from 2 to 10 solution 2
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // multiplication table
            Console.WriteLine("Multiplication table");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Multiplication table for {i}");
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write($"{i} * {k} = ");
                    Console.WriteLine(i * k);
                }
                Console.WriteLine();
            }

            /* sequenced numbers
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             * etc.. */
            Console.WriteLine("Numbers sequence");
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($" {k}");
                }
                Console.WriteLine();
            }
        }
    }
}
