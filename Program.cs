using System.Collections;

namespace GenericExamples
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add("sdsda");
            array.Add(true);
            array.Add(false);

            List<DateTime> list = new List<DateTime>();
            list.Sort();

            // SELECT * from student
            // SELECT rno, name FROM STUDENT ODRDER BY Name

            //LINQ

            var processCollection = from proc in System.Diagnostics.Process.GetProcesses()
                                    where proc.ProcessName.Length > 10
                                    orderby proc.ProcessName
                                    select new { proc.ProcessName, proc.ProcessName.Length };

            foreach( var proc in processCollection )
            {
                //Console.WriteLine(proc.ProcessName + "   "+ proc.Length);
            }


            List<Student> students = new List<Student>();
            
            students.Add(new Student { Id = 1, Name = "Anu", Mark = 89 });
            students.Add(new Student { Id = 2, Name = "Rajiv", Mark = 89 });
            students.Add(new Student { Id = 45, Name = "TamilMani", Mark = 79 });
            students.Add(new Student { Id = 5, Name = "Kala", Mark = 98 });
            students.Add(new Student { Id = 3, Name = "Sita", Mark = 99 });

            var studentColl = from stu in students 
                              where stu.Mark<90
                              orderby stu.Id descending
                              select new { stu.Id, stu.Name,stu.Mark };

            foreach (var student in studentColl)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Mark);

                Console.WriteLine("_____________________________________________________________");
            }

            var markList = students.Select(s=>new { s.Name, s.Mark }).ToList();

        }
    }
}
