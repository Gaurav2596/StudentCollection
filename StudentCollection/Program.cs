using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentCRUD crud = new StudentCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Delete Student");
                Console.WriteLine("4.Display All Details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Student s1 = new Student();
                        Console.WriteLine("Enter stud id");
                        s1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter stud name");
                        s1.Name = Console.ReadLine();
                        Console.WriteLine("Enter stud rollno");
                        s1.Rollno = Convert.ToInt32(Console.ReadLine());

                        crud.AddStudent(s1);
                        break;

                    case 2:
                        Student s2 = new Student();
                        Console.WriteLine("Enter id to modify");
                       
                        s2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter stud Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter stud rollno");
                        s2.Rollno = Convert.ToInt32(Console.ReadLine());

                        crud.UpdateStudent(s2);
                        break;

                    case 3:
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(id);
                        break;

                    case 4:
                        List<Student> list = crud.GetStudents();
                        foreach (Student s in list)
                        {
                            Console.WriteLine($"{s.Id}-->{s.Name}-->{s.Rollno}");

                        }
                        break;


                }
                Console.WriteLine("Press 1 for continue");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option == 1);
        }
    }
}

        
