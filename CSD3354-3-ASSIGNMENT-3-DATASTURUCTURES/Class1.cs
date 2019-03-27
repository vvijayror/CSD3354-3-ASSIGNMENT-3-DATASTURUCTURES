using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_3_ASSIGNMENT_3_DATASTURUCTURES
{
   
    // Vijay C0722852
    // Aman Malik C0730457
    public delegate void Sort_DataStructure();

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            DataStructureQueue a = new DataStructureQueue();
        }
    }

    class Student
    {
        String Student_name;
        double[] StudentID;
        double[] StudentGPA;


        List<string> names = File.ReadAllLines("U:/Users/722852/names.txt").ToList();
        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];

            StudentID = new double[names.Count];
            for (int i = 0; i < names.Count; i++)
            {
                StudentID[i] = r1.Next(1000, 9999); ;
            }
            StudentGPA = new double[names.Count];
            for (int i = 0; i < names.Count; i++)
            {
                StudentGPA[i] = r1.Next(1, 99); ;
            }
        }
        public void Display()
        {
            foreach (string i in names)
            {
            }
        }

        public void AverageStudentGPA()
        {

            double average = 0;
            double num = 0;
            Console.WriteLine("Student GPA - ");
            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(StudentGPA[i] + " ");
                num += StudentGPA[i];
                average = num / names.Count;
            }
            Console.WriteLine(" ");
            Console.WriteLine("The overall average of Student GPA is " + average);
        }
    }

    public interface IDataStructure
    {
        void Sort();
    }

    class DataStructureQueue : IDataStructure
    {


        public Queue q1 = new Queue();

        Sort_DataStructure Sort1;

        public void Sorter()
        {
            // TO DO : sort the Queue 
            /* q1.Enqueue("Java-Sat-AM-A202");
             q1.Enqueue("C#.Net-MON-PM-A122");
             q1.Enqueue("MATH-FRI-AM-A506");
             q1.Enqueue("BIGDATA-THU-AM-B230");
             q1.Enqueue("Java-WED-PM-A202");
             q1.Enqueue("C#>Net-THU-PM-B125");
             q1.Enqueue("MATH-TUE-AM-B130");
             q1.Enqueue("EMERGINGTECGNOLOGY-FRI-PM-B122");
             q1.Enqueue("MOcrosoftDATASTACK-MON-AM-B122");
             q1.Enqueue("MATH-MON-PM-A222");
             */
        }

        public void Run()
        {
            for (int i = 0; i <= 10; i++)
            {
                q1.Enqueue(new Student());
            }
            Sort1 = new Sort_DataStructure(Sorter);
        }
        public void Sort()
        {

        }

    }
}
namespace BubbleSort
{
    class MySort
    {
        static void Main2(string[] args)

        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("sorted: ");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}