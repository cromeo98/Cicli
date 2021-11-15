using System;

namespace Cicli
{
    public class Persona //Classe d'istanza
    {
        string name;
        string lastname;
        double height;

        public Persona(string name, string lastname) //Primo costruttore
        {
            this.name = name;
            this.lastname = lastname;
        }

        public Persona() //Secondo costruttore
        {

        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        //public void setName(string userName)
        //{
        //    name = userName;
        //}
        //public void setLastname(string userLastname)
        //{
        //    lastname = userLastname;
        //}

        //public string getName()
        //{
        //    return name;
        //}

        //public string getLastname()
        //{
        //    return lastname;
        //}


        //Metodi sovraccaricabili
        public void setHeigth(int userHeigth)
        {
            height = userHeigth;
            Console.WriteLine(height);
        }

        public void setHeigth(double userHeigth)
        {
            height = userHeigth;
            Console.WriteLine(height);
        }

        public void setHeigth()
        {
            Console.WriteLine("Hi");
        }
    }
}
