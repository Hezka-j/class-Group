using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Student
{
    internal class Student 
    {
        string name;
        string secondname;
        string lastname;
        DateTime birthday;
        List<int> homeworkRates = new List<int>();
        List<int> classworkRates = new List<int>();
        List<int> examRates = new List<int>();

        public Student() : this("Student", "Studentov") { }
        public Student(string name, string lastname) : this(name, " ", lastname, new DateTime(5534, 12, 3)) { }
        public Student(string name, string secondname, string lastname, DateTime birthday) : this(name, secondname, lastname, new DateTime(2222, 12, 12), new List<int>(), new List<int>(), new List<int>()) { }
        public Student(string name, string secondname, string lastname, DateTime birthday, List<int> homework_rates, List<int> classwork_rates, List<int> exam_rates)
        {           
            SetName(name);
            SetSecondName(secondname);
            SetLastName(lastname);
            SetBirthday(birthday);
            SetHomeworkRates(homeworkRates);
            SetClassWorkRates(classworkRates);
            SetExamRates(examRates);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetLastName()
        {
            return this.lastname;
        }

        public void SetSecondName(string secondname)
        {
            this.secondname = secondname;
        }

        public string GetSecondName()
        {
            return this.secondname;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetHomeworkRates(List<int> homeworkRates)
        {
            this.homeworkRates = homeworkRates;
        }

        public void SetHomeworkRates(params int[] homeworkRates)
        {
            for(int i = 0; i < homeworkRates.Length; i++)
            {
                this.homeworkRates.Add(homeworkRates[i]);
            }
        }

        public List<int> GetHomeworkRates()
        {
            return this.homeworkRates;
        }

        public void SetClassWorkRates(List<int> classworkRates)
        {
            this.classworkRates = classworkRates;
        }

        public void SetClassWorkRates(params int[] classworkRates)
        {
            for(int i = 0; i < classworkRates.Length; i++)
            {
                this.classworkRates.Add(classworkRates[i]);
            }
        }

        public List<int> GetClassworkRates()
        {
            return this.classworkRates;
        }

        public void SetExamRates(List<int> examRates)
        {
            this.examRates = examRates;
        }

        public void SetExamRates(params int[] examRates)
        {          
             for (int i = 0; i < examRates.Length; i++)
             {
                 this.examRates.Add(examRates[i]);
             } 
        }

        public List<int> GetExamRates()
        {
            return this.examRates;
        }
       
    }

    class StudentPrinter
    {        
        static public void Print(in Student student)
        {
            Console.WriteLine(student.GetName() + " " + student.GetSecondName() + " " +student.GetLastName());
            Console.WriteLine(student.GetBirthday());

            for(int i = 0; i < student.GetHomeworkRates().Count; i++)
            {
                Console.Write(student.GetHomeworkRates()[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < student.GetClassworkRates().Count; i++)                
            {
                Console.Write(student.GetClassworkRates()[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < student.GetExamRates().Count; i++)
            {
                Console.Write(student.GetExamRates()[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

