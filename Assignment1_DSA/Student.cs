using System;
using System.Collections.Generic;
namespace Assignment1_DSA
{
    public class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        float averageScore;


        public Student(string F, string L, string S, float A)
        {
            this.firstName = F;
            this.lastName = L;
            this.studentNumber = S;
            this.averageScore = A;
        }


        public string FirstName 
        {
            get { return firstName; } set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; } set { lastName = value; }
        }
        public string StudentNumber
        {
            get { return studentNumber; } set { studentNumber = value; }
        }
        public float AverageScore
        {
            get { return averageScore; } set { averageScore = value; }
        }


        public string toString ()
        {
            return firstName + " " + lastName + " with the student number " + studentNumber + " has a score of " + averageScore;
        }
    }
}
