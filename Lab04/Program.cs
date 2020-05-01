using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Person> lLinkedList = new LinkedList<Person>();

            Person[] objPeople = new Person[4]
            {
                new Person("Sebastian", "Eli Fors", 26),
                new Person("Janusz", "Kowalski", 12),
                new Person("Adam", "Nowak", 45),
                new Person("Last", "Person", 76)
            };

            lLinkedList.Add(objPeople[0]);
            lLinkedList.Add(objPeople[1]);
            lLinkedList.Add(objPeople[2]);
            lLinkedList.Add(objPeople[3]);

            Console.WriteLine(lLinkedList.Size);

            try
            {
                lLinkedList.RemoveAt(lLinkedList.Size - 1);
                lLinkedList.RemoveAt(lLinkedList.Size - 1);
                lLinkedList.RemoveAt(lLinkedList.Size - 1);

                lLinkedList.RemoveAt(0);
                lLinkedList.RemoveAt(15);
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }

            try
            {
                lLinkedList.Add(objPeople[0]);
                lLinkedList.Add(objPeople[1]);
                lLinkedList.Add(objPeople[2]);
                lLinkedList.Add(objPeople[3]);

                lLinkedList.Remove(objPeople[2]); // Usuniecie z srodka
                lLinkedList.Remove(objPeople[3]); // Usuniecie ostatniego
                lLinkedList.Remove(objPeople[0]); // Usuniecie pierwszego
                lLinkedList.Remove(objPeople[1]); // Usuwamy ostatnia osobe

                lLinkedList.Remove(new Person("Unknown", "Unknown", 16)); // Proba usuniecia kogos nie znajdujacego sie w liscie
            }
            catch (KeyNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }

            lLinkedList.Insert(0, objPeople[0]);
            lLinkedList.Add(objPeople[2]);
            lLinkedList.Add(objPeople[3]);
            lLinkedList.Insert(1, objPeople[1]);
            lLinkedList.Insert(4, objPeople[1]);

            var lOver18 = lLinkedList.Where(e => e.Age >= 18);

            foreach (Person p in lOver18)
                Console.WriteLine(p);

            Console.WriteLine(lLinkedList.Size);

            DoublyLinkedList<Person> lDoublyLinked = new DoublyLinkedList<Person>();

            lDoublyLinked.Add(objPeople[0]);
            lDoublyLinked.Add(objPeople[1]);
            lDoublyLinked.Add(objPeople[2]);
            lDoublyLinked.Add(objPeople[3]);


           foreach(Person p in lDoublyLinked)
                Console.WriteLine(p);

            lDoublyLinked.Insert(3, new Person("John", "Kappa", 34));
            lDoublyLinked.Insert(0, new Person("Test", "Testing", 34));

            lDoublyLinked.RemoveAt(2);
            lDoublyLinked.RemoveAt(0);

            lDoublyLinked.Remove(objPeople[2]);

            Console.WriteLine("-----------------------------------");

            DoublyLinkedListRev<Person> lDoublyLinkedRev = new DoublyLinkedListRev<Person>();

            lDoublyLinkedRev.Add(objPeople[0]);
            lDoublyLinkedRev.Add(objPeople[1]);
            lDoublyLinkedRev.Add(objPeople[2]);
            lDoublyLinkedRev.Add(objPeople[3]);

            foreach (Person p in lDoublyLinkedRev)
                Console.WriteLine(p);

            Console.Read();
        }
    }
}
