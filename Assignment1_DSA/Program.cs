using System;
using System.Collections.Generic;

namespace Assignment1_DSA
{
    class Program
    {
        static public float[] Scores(int numberOfScores)
        {
            Console.WriteLine("Enter his grades one by one");
            float[] scores = new float[numberOfScores];
            for (int i = 0; i < numberOfScores; i++)
            {
                scores[i] = Convert.ToSingle(Console.ReadLine());
            }
            return scores;
        }

        static public float CalculateAverageScore(float[] scores)
        {
            float averageS = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                averageS += scores[i];
            }
            averageS /= scores.Length;
            return averageS;
        }







        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            LinkedList<Student> list = new LinkedList<Student>();
            CustomDataList classroom = new CustomDataList(list);
            classroom.PopulateWithSampleData();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu :\n"
                                 + "Option 1 : Add a student\n"
                                 + "Option 2 : Remove a student\n"
                                 + "Option 3 : Get a particular student\n"
                                 + "Option 4 : See the whole classroom\n"
                                 + "\n"
                                 + "Pick the chosen option ");
                Console.WriteLine();
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("What is his first and last name ? And after enter his student number");
                        string F = Convert.ToString(Console.ReadLine());
                        string L = Convert.ToString(Console.ReadLine());
                        string S = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("How many grades does he have ? Then enter them one by one");
                        int nb = Convert.ToInt32(Console.ReadLine());
                        float[] scores = Scores(nb);
                        float averageS = CalculateAverageScore(scores);
                        Student student = new Student(F, L, S, averageS);
                        Console.WriteLine("\n"
                                            + "Here is the student that you have created :\n"
                                            + student.toString() + "\n"
                                            + "\n"
                                            + "Do you want to add him to the class ? Enter yes if so");
                        string verif = Convert.ToString(Console.ReadLine());
                        if (verif == "yes" || verif == "YES") { classroom.Add(student); }
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Which student do you want to remove ?\n"
                                + "1 : The first one\n"
                                + "2 : The last one\n"
                                + "3 : A special one\n");
                        int opt2 = Convert.ToInt32(Console.ReadLine());
                        switch (opt2)
                        {
                            case 1:
                                classroom.RemoveFirst();
                                break;
                            case 2:
                                classroom.RemoveLast();
                                break;
                            case 3:
                                Console.WriteLine("Here is the whole classroom :\n"
                                                    + "\n");
                                classroom.DisplayList();
                                Console.WriteLine("Which one do you want to remove ? Enter the number where he is placed");
                                int index = Convert.ToInt32(Console.ReadLine());
                                classroom.RemoveByIndex(index);
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("");
                        int nbS = classroom.Count;
                        Console.WriteLine("Right now, there is " + nbS + " students in the classroom, which one do you want to see ?");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        Student studentGet = classroom.GetElement(index2);
                        Console.WriteLine();
                        Console.WriteLine("The student you asked is : " + studentGet.toString());
                        break;

                    case 4:
                        classroom.DisplayList();
                        break;

                }
                Console.WriteLine("Press Esc to exit or any other keyboard key to return to the menu");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
