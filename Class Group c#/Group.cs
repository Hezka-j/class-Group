using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using class_Student;


namespace class_Group
{
    interface ICopy
    {
        Group Copy();
    }
    internal class Group : ICopy
    {
        List<Student> students = new List<Student>();
        string name;
        int courseNumber;       
        Speciallization groupSpeciallization;

        public enum Speciallization
        {
            Programming,
            Designer
        }
        public Group() : this("", 0, 0, new List<Student>()) {}
        public Group(string name, int courseNumber, Speciallization groupSpeciallization, List<Student> students)
        {
            SetStudentsList(students);
            SetName(name);
            SetCourseNumber(courseNumber);
            SetSpeciallization(groupSpeciallization);
        }
        public Group Copy()
        {
            List<Student> student = new List<Student>();
            for(int i = 0; i < this.students.Count; i++)
            {
                student.Add(this.students[i]);
            }
            return new Group(this.name, this.courseNumber, this.groupSpeciallization, student);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetCourseNumber(int courseNumber)
        {
            this.courseNumber = courseNumber;
        }

        public int GetCourseNumber()
        {
            return this.courseNumber;
        }

        public void SetSpeciallization(Speciallization speciallization)
        {
            this.groupSpeciallization = speciallization;
        }

        public Speciallization GetSpeciallization()
        {
            return this.groupSpeciallization;
        }

        public void SetStudentsList(List<Student> students)
        {
            this.students = students;
        }

        public List<Student> GetStudentList()
        {
            return this.students;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void DeleteStudent(in Student student)
        {
            this.students.Remove(student);
        }
        public void TransferStudent(in Student student, Group group)
        {
            this.DeleteStudent(student);
            group.students.Add(student);
        }

        public void ExpulsionFallingStudents()
        {
            foreach (var item in this.students)
            {
                double average = 0;
                for (int i = 0; i < item.GetExamRates().Count; i++)
                    average += item.GetExamRates()[i];
                average /= item.GetExamRates().Count;
                if(average < 6)
                {
                    this.DeleteStudent(item);
                }
            }
        }
        public void StudentsExpulsion()
        {           
            for(int i = 0; i < this.students.Count; i++)
            {
                for (int j = 0; j < students[i].GetExamRates().Count; j++)
                {
                    if (students[i].GetExamRates()[j] < 6)
                    {
                        this.DeleteStudent(students[i]);
                        i--;
                        break;
                    }
                }
            }                  
        }
    }

    class GroupePrinter
    {         
        static public void Print(in Group group)
        {
            Console.WriteLine(group.GetName());
            Console.WriteLine(group.GetCourseNumber());
            Console.WriteLine(group.GetSpeciallization());

                   
            for (int i = 0; i < group.GetStudentList().Count; i++)
            { 
                Student c = group.GetStudentList()[i];
                StudentPrinter.Print(c);
            }
            Console.WriteLine();
        }      
    }
}
