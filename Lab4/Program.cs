using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Student
    {
        private double height;
        private double weight;
        private string color_eyes;
        private string color_hair;
        private string name;
        public double Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }

        public double Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }

        public string ColorEyes
        {
            set
            {
                color_eyes = value;
            }
            get
            {
                return color_eyes;
            }
        }

        public string ColorHair
        {
            set
            {
                color_hair = value;
            }
            get
            {
                return color_hair;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }

    class CompareHeight : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.Height > s2.Height)
            {
                return 1;
            }
            else if (s1.Height < s2.Height)
            {
                return -1;
            }
            else
                return 0;
        }
    }

    class CompareWeight : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.Weight > s2.Weight)
            {
                return -1;
            }
            else if (s1.Weight < s2.Weight)
            {
                return 1;
            }
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr_student = new Student[10];
            Random r = new Random();

            string[] colors = { "blue", "red", "black", "green" };
            string[] names = { "Grag", "Manny", "Poul", "Alice", "Jane", "Max" };

            for (int i = 0; i < arr_student.Length; i++)
            {
                arr_student[i] = new Student();
                arr_student[i].ColorEyes = colors[r.Next(0, colors.Length - 1)];
                arr_student[i].ColorHair = colors[r.Next(0, colors.Length - 1)];
                arr_student[i].Name = names[r.Next(0, names.Length - 1)];
                arr_student[i].Weight = r.Next(60, 131);
                arr_student[i].Height = r.Next(150, 211);
            }

            Console.WriteLine("No Sort:");

            for (int i = 0; i < arr_student.Length; i++)
            {
                Console.WriteLine($"Heigt is {arr_student[i].Height} Weight is {arr_student[i].Weight}");
            }

            Console.WriteLine(new string('-', 20));

            Array.Sort(arr_student, new CompareHeight());

            Console.WriteLine("Sort Height increase:");

            for (int i = 0; i < arr_student.Length; i++)
            {
                Console.WriteLine($"Heigt is {arr_student[i].Height} Weight is {arr_student[i].Weight}");
            }

            Console.WriteLine(new string('-', 20));

            Array.Sort(arr_student, new CompareWeight());

            Console.WriteLine("Sort Weight subsidence:");

            for (int i = 0; i < arr_student.Length; i++)
            {
                Console.WriteLine($"Heigt is {arr_student[i].Height} Weight is {arr_student[i].Weight}");
            }

            Console.ReadKey();
        }
    }
}
