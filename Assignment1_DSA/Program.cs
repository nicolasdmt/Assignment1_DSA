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
                Console.WriteLine("Menu :\n"
                                 + "Option 1 : See the whole classroom\n"
                                 + "Option 2 : Add a student\n"
                                 + "Option 3 : Remove a student\n"
                                 + "Option 4 : Sort the classroom\n"
                                 + "Option 5 : Get a particular student\n"
                                 + "Option 6 : Get the student with the best score\n"
                                 + "Option 7 : Get the student with the lowest score\n"
                                 + "\n"
                                 + "Pick the chosen option ");
                Console.WriteLine();
                int opt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opt)
                {
                    case 1:
                        classroom.DisplayList();
                        break;

                    case 2:
                        Console.WriteLine("\nWhat is his first and last name ? And after enter his student number\n");
                        string F = Convert.ToString(Console.ReadLine());
                        string L = Convert.ToString(Console.ReadLine());
                        string S = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("How many grades does he have ? Then enter them one by one");
                        int nb = Convert.ToInt32(Console.ReadLine());
                        float[] scores = Scores(nb);
                        float averageS = CalculateAverageScore(scores);
                        Student student = new Student(F, L, S, averageS);
                        Console.WriteLine("\n"
                                            + "Here is the student that you have created :\n"
                                            + student.toString() + "\n"
                                            + "\nDo you want to add him to the class ? Enter yes if so\n");
                        string verif = Convert.ToString(Console.ReadLine());
                        if (verif == "yes" || verif == "YES") { classroom.Add(student); }
                        break;

                    case 3:
                        Console.WriteLine("\nWhich student do you want to remove ?\n"
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
                                Console.WriteLine("Which one do you want to remove ? Enter the number where he is placed\n");
                                int index = Convert.ToInt32(Console.ReadLine());
                                classroom.RemoveByIndex(index);
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("By which parameter do you want to sort the classroom ?\n"
                                    + "1: with the last names\n"
                                    + "2: with the first names\n"
                                    + "3: with the student numbers\n"
                                    + "4: with the scores\n");
                        int opt3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nDo you want to sort the classroom by ascending order or descending ?\n"
                                    + "1: by ascending order\n"
                                    + "2: by descending disorder\n");
                        int opt4 = Convert.ToInt32(Console.ReadLine());
                        classroom.Sort(opt4,opt3);
                        Console.WriteLine("\nThe classroom is now sorted");
                        break;

                    case 5:
                        Console.WriteLine("\nFrom which student do you want to see the information ? Enter a number\n");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        Student studentGet = classroom.GetElement(index2);
                        Console.WriteLine("\nThe student you asked is : " + studentGet.toString());
                        break;

                    case 6:
                        Console.WriteLine(classroom.GetMaxElement());
                        break;

                    case 7:
                        Console.WriteLine(classroom.GetMinElement());
                        break;

                }
                Console.WriteLine("\nPress Esc to exit or any other keyboard key to return to the menu");
                cki = Console.ReadKey();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
