using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Brian1", 1);
            Node n1 = new Node(1, p1);
            
            Person p2 = new Person("Brian2", 2);
            Node n2 = new Node(2, p2);
            
            Person p3 = new Person("Brian3", 3);
            Node n3 = new Node(3, p3);
            
            Person p4 = new Person("Brian4", 4);
            Node n4 = new Node(4, p4);
            
            Person p5 = new Person("Brian5", 5);
            Node n5 = new Node(5, p5);
            
            Person p6 = new Person("Brian6", 6);
            Node n6 = new Node(6, p6);
            
            Person p7 = new Person("Brian7", 7);
            Node n7 = new Node(7, p7);
            
            Person p8 = new Person("Brian8", 8);
            Node n8 = new Node(8, p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            
            VisitorAge totalAge = new VisitorAge();
            totalAge.Visit(n1);
            Console.WriteLine($"Age: {totalAge.Content()}");
        }
    }
}
