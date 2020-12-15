using System;
using System.Collections.Generic;
namespace Assignment1_DSA
{
    public class CustomDataList
    {
        LinkedList<Student> classroom;


        public CustomDataList(LinkedList<Student> C)
        {
            this.classroom = C;
        }


        public LinkedList<Student> Classroom
        {
            get { return classroom; } set { classroom = value; }
        }


        public int Count { get; }


        //Methods :

        public void PopulateWithSampleData()
        {
            string first1 = "Nicolas"; string last1 = "Dumont"; string nb1 = "L-20-08"; float av1 = 75;
            Student student1 = new Student(first1, last1, nb1, av1); classroom.AddFirst(student1);
            string first2 = "Pierre"; string last2 = "Vandergooten"; string nb2 = "L-20-09"; float av2 = 12;
            Student student2 = new Student(first2, last2, nb2, av2); classroom.AddFirst(student2);
            string first3 = "Maxime"; string last3 = "Barbier"; string nb3 = "L-20-03"; float av3 = 80;
            Student student3 = new Student(first3, last3, nb3, av3); classroom.AddFirst(student3);
            string first4 = "Gatien"; string last4 = "Fournier"; string nb4 = "L-20-01"; float av4 = 66;
            Student student4 = new Student(first4, last4, nb4, av4); classroom.AddFirst(student4);
            string first5 = "Paul"; string last5 = "Chaumont"; string nb5 = "L-20-13"; float av5 = 94;
            Student student5 = new Student(first5, last5, nb5, av5); classroom.AddFirst(student5);
        }


        public void Add(Student student)
        {
            Console.WriteLine("Where do you want to add the student ?\n"
                                + "1 : At the beginning\n"
                                + "2 : At the end\n");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    classroom.AddFirst(student);
                    break;
                case 2:
                    classroom.AddLast(student);
                    break;
            }
        }


        public Student GetElement(int index)
        {
            Student[] copy = new Student[classroom.Count];
            classroom.CopyTo(copy, 0);
            return copy[index - 1];
        }

        //For those 2 methods, GetElement and RemoveByIndex, I created an array to find a specific index
        //in the linkedList like there is no methods in C# to get and remove an index that you want
        public void RemoveByIndex(int index)
        {

            Student[] copy = new Student[classroom.Count];
            classroom.CopyTo(copy, 0);
            Student removed = copy[index - 1];
            classroom.Remove(removed);
        }


        public void RemoveFirst()
        {
            classroom.RemoveFirst();
        }


        public void RemoveLast()
        {
            classroom.RemoveLast();
        }


        public void DisplayList()
        {
            Console.WriteLine("\nStudents in the classroom are in order :\n");
            foreach (Student student in classroom)
            {
                Console.WriteLine(student.toString());
            }
            Console.WriteLine();
        }
    }
}