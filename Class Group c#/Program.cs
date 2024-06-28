using class_Group;
using class_Student;
namespace Class_Group
{
    internal class Program
    {
        static void Main()
        {
            
            Student alex = new Student("Alex", "Asf", "Toren", new DateTime(1999, 5, 24));        
            alex.SetExamRates(12, 12, 10, 10);
            alex.SetHomeworkRates(12, 11, 10, 10);
            alex.SetClassWorkRates(12, 12, 10, 10);
            Student viva = new Student("Viva", "Vbn", "Sire", new DateTime(2005, 8, 21));
            viva.SetExamRates(8, 9, 10, 10);
            viva.SetHomeworkRates(8, 9, 10, 10);
            viva.SetClassWorkRates(8, 9, 10, 10);
            Student lev = new Student("Lev", "FDf", "Tomato", new DateTime(1980, 7, 12));
            lev.SetExamRates(7, 3, 8, 4);
            lev.SetHomeworkRates(7, 5, 8, 9);
            lev.SetClassWorkRates(7, 5, 8, 9);
            Student max = new Student("Max", "Studentf", "Normal", DateTime.Now);
            max.SetExamRates(10, 5, 9, 11);
            max.SetHomeworkRates(10, 10, 9, 11);
            max.SetClassWorkRates(10, 10, 9, 11);

            Group p = new Group();           
            p.SetName("P26");
            p.SetCourseNumber(2);
            p.SetSpeciallization(Group.Speciallization.Programming);           
            p.AddStudent(alex);
            p.AddStudent(max);

            Group p2 = p.Copy();
            GroupePrinter.Print(p2);
            
            
            //p.DeleteStudent(alex);
            p.TransferStudent(alex, p2);
            GroupePrinter.Print(p);
            p2.SetName("dgdgdg");
            GroupePrinter.Print(p2);
            //p.StudentsExpulsion();
         
            
        }
    }
}
