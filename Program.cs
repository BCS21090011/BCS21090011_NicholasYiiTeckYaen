using System;
using System.Collections.Generic;

public class ObjectOrientedProgrammingCourse
{

    class SetStudentDetail
    {

        public string studentName { get; set; }
        public string studentId { get; set; }
        public string identificationCard { get; set; }
        public decimal mark { get; set; }

        public SetStudentDetail(string StudentName, string StudentId, string IdentificationCard, decimal Mark)
        {
            this.studentName = StudentName;
            this.studentId = StudentId;
            this.identificationCard = IdentificationCard;
            this.mark = Mark;
        }

        public class Student
        {
            static void Main(string[] args)
            {

                void DisplayAllStudentDetails(List<SetStudentDetail> person)
                {

                    person.Sort((p1, p2) => string.Compare(p1.studentName, p2.studentName));

                    foreach (SetStudentDetail p in person)
                    {
                        Console.WriteLine("\t" + p.studentName + "\t\t\t" + p.studentId + "\t\t\t" + p.identificationCard);
                    }

                }

                void DisplayAllStudentRanking(List<SetStudentDetail> person)
                {

                    person.Sort((p1, p2) => p2.mark.CompareTo(p1.mark));

                    foreach (SetStudentDetail p in person)
                    {
                        Console.WriteLine("\t" + p.mark + "\t\t\t" + p.studentName);
                    }

                }

                List<SetStudentDetail> person = new List<SetStudentDetail>(5);

                person.Add(new SetStudentDetail("Mark", "BCS0001", "0111222333", 50));
                person.Add(new SetStudentDetail("Bill ", "BCS0002", "0222333444", 70));
                person.Add(new SetStudentDetail("Jeff", "BCS0003", "0555666777", 40));
                person.Add(new SetStudentDetail("Elon", "BCS0004", "0888999000", 20));
                person.Add(new SetStudentDetail("Antony", "BCS0005", "1111222333", 30));

                Console.WriteLine("\t\t\tStudent Details:");
                DisplayAllStudentDetails(person);

                Console.WriteLine("\n\t\t\tStudent Ranking:");
                DisplayAllStudentRanking(person);

                Console.ReadLine();

            }

        }

    }

}