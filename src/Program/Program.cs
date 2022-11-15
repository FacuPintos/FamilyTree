using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person ("Charles",69);
            Person p2 = new Person ("Carly",42);
            Person p3 = new Person ("Charly",25);
            Person p4 = new Person ("Carlos",33);
            Person p5 = new Person ("Carlitos",5);
            Person p6 = new Person ("Helmut",24);
            Person p7 = new Person ("Bronnie",17);
            Person p8 = new Person ("LeBron",35);


            Node<Person> np1 = new Node <Person> (p1);
            Node<Person> np2 = new Node <Person> (p2);
            Node<Person> np3 = new Node <Person> (p3);
            Node<Person> np4 = new Node <Person> (p4);
            Node<Person> np5 = new Node <Person> (p5);
            Node<Person> np6 = new Node <Person> (p6);
            Node<Person> np7 = new Node <Person> (p7);
            Node<Person> np8 = new Node <Person> (p8);

            //en el nodo de Charles agrego estos dos:
        
            np1.AddChildren(np3); //agrego a Charly como hijo de Charles
            np1.AddChildren(np8); //agrego LeBron como hijo de Charles

            
            //en el nodo de Carly agrego estos dos:
        
            np2.AddChildren(np3); //agrego a Charly como hijo de Carly
            np2.AddChildren(np8); //agrego LeBron como hijo de Carly

            //en el nodo de Charly agrego estos dos:
        
            np3.AddChildren(np5); //agrego a Carlitos como hijo de Charly
            np3.AddChildren(np6); //agrego Helmut como hijo de Charly
            np3.AddChildren(np8); //agrego LeBron como hijo de Charly

            //en el nodo de Carlos agrego estos dos:
        
            np4.AddChildren(np5); //agrego a Charly como hijo de Charly
            np4.AddChildren(np6); //agrego Helmut como hijo de Charly
            np4.AddChildren(np8); //agrego LeBron como hijo de Charly

            //en el nodo de LeBron agrego estos dos:
        
            np3.AddChildren(np7); //agrego a Carlitos como hijo de LeBron         

            //creo instancia de los visitadores:

            SumVisitor v1 = new SumVisitor();
            VisitorName v2 = new VisitorName();
            VisitorOld v3 = new VisitorOld();

            v1.Visit (np4);
            v2.Visit (np4);
            v3.Visit (np4);

            np1.Accept(v1);
            Console.WriteLine($"Suma de edades:{v1.SumaEdades}");

            np1.Accept(v2);
            Console.WriteLine($"Nombre mas largo es {v2.LongestName}");

            np1.Accept(v3);
            Console.WriteLine($"El mas viejo es: {v3.OldestKid}");

        }
    }
}
