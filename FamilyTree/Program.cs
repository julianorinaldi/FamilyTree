using System;
using System.Runtime.InteropServices.ComTypes;

namespace FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Person joao1 = new Person("Joao1", Gender.Male);
            Person maria1 = new Person("Maria1", Gender.Female);
            ; ; Person joao2 = new Person("Joao2", Gender.Male, joao1, maria1);


            Person pedro1 = new Person("Pedro1", Gender.Male);
            Person pedro1BrotherFabio1 = new Person("Fabio1", Gender.Male);
            pedro1.Brothers.Add(pedro1BrotherFabio1);
            Person rafaela1 = new Person("Rafaela1", Gender.Female);

            ; ; Person joana2 = new Person("Joana2", Gender.Female, pedro1, rafaela1);

            ; ; ; ; Person claudia3 = new Person("Claudia3", Gender.Female, joao2, joana2);


            Person carlos1 = new Person("Carlos1", Gender.Male);
            Person juliana1 = new Person("Juliana1", Gender.Female);
            ; ; Person jose2 = new Person("Jose2", Gender.Male, carlos1, juliana1);

            Person antonio1 = new Person("Antonio1", Gender.Male);
            Person julia1 = new Person("Julia1", Gender.Female);
            ; ; Person aline2 = new Person("Aline2", Gender.Female, antonio1, julia1);

            ; ; ; ; Person felipe3 = new Person("Felipe3", Gender.Male, jose2, aline2);

            Person juliano4 = new Person("Juliano4", Gender.Male, felipe3, claudia3);

            WriteGenealogical(juliano4);
            Console.ReadKey();
        }

        public static void WriteGenealogical(Person personStart)
        {
            foreach (var person in personStart.Brothers)
                Console.WriteLine(person.Name);

            if (personStart.Father != null)
                WriteGenealogical(personStart.Father);

            if (personStart.Mother != null)
                WriteGenealogical(personStart.Mother);

            Console.WriteLine(personStart.Name);
        }
    }
}
