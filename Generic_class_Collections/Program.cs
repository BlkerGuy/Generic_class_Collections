using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Generic_class_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Collection Practice:
            //List<T>

            List<int> evenNums = new List<int>();

            int? num = null;
            evenNums.Add(2);
            evenNums.Add(4);
            evenNums.Add(6);
            evenNums.Add(8);
            //evenNums.Add(num); //Cunki Compile Erorr vererek Runtime zamani olan partlayisin(exception) qarsisini alir.
            Console.WriteLine("EvenNums:");
            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }
            List<string> bookColors = new List<string>();
            bookColors.Add(10.ToString());
            bookColors.Add("Blue Book");
            bookColors.Add("Red Book");
            bookColors.Add("Green Book");
            bookColors.Add(null);
            Console.WriteLine("Book Colors':");
            foreach (var item in bookColors)
            {
                Console.WriteLine(item);
            }

            //var newEvenBooks = new List<T>();

            //List<Student> students = new List<Student>();

            string[] colors = new string[3] { "blue", "red", "green" };

            List<string> ColorOFBOOk = new List<string>();

            ColorOFBOOk.AddRange(colors);
            Console.WriteLine("Color of Books:");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }

            //string[] booksWithColor = new string[] { null };

            //ColorOFBOOk.AddRange(booksWithColor);
            //for (int i = 0; i < booksWithColor.Length; i++)
            //{
            //    Console.WriteLine(booksWithColor[0]);
            //}


            byte x = 10;
            byte y = 5;
            byte z = 20;
            Sum(ref x, y);
            Console.WriteLine(x + z);

            ArrayList arrayList = new ArrayList();

            arrayList.AddRange(colors);
            arrayList.Add("Alma");
            arrayList.Add("Sleep");
            arrayList.Add(10);
            arrayList.Add(num);
            Console.WriteLine("ArrayList deyerleri:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            var students = new List<Student>() {
                new Student{ Name = "Hikmet" },
                new Student { Name = "Elcin" }
            };


            //Bu yazilisi vermediyinizi bilirem:) amma oyrenmek plusdu :D)
            var result = from s in students     // List<Student>students= new List<Student>(); bu listin Linq yazilisi;
                         //where s.Name == "Hikmet"
                         select s.Name;
            students.Insert(0, new Student { Name = "Abuzer" });
            foreach (var item in result)
                Console.WriteLine(item);




            int[] nom = new int[] { 10, 20, 30, 40, 50 };

            for (int i= 1; i < nom.Length-1; i++)
            {
                    //20
              /*  var oldnum = nom[i];*/                     //oldnum=20
              /* 30*/  nom[i] = nom[i + 1];              //nom[20]=nom[30]
              /* 30*/  /*nom[i + 1] = oldnum;*/              //nom[40]=20
            }
            Array.Resize(ref nom, nom.Length - 1);
          
            Console.Write(String.Join(",", nom));


        }

        public static void Sum( ref byte x, byte y, byte z = 0  )
        {
            x = 100;
            z = 25;
        }

       MyClass<int> intList = new MyClass<int>();

    }
    class Student
    {
        public string Name;
    }

    class MyClass
    {
        public void Sum(int a,int b)
        {
            var result =a + b;
        }
    }
   
}
