using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rollno { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student> students;
        public StudentCRUD()
        {
                students = new List<Student>();
        }
        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }
        public void UpdateStudent(Student stud) 
        { 
            foreach (Student s in students)
            { 
                if(s.Id == stud.Id)
                {
                    s.Name = stud.Name;
                    s.Rollno = stud.Rollno;
                    break;
                }
            
            }
        }
        public void DeleteStudent(int id) 
        { 
            foreach(Student s in students)
            {
                if(s.Id == id)
                {
                    students.Remove(s);
                    break;
                }
            }
        
        }
        public List<Student> GetStudents()
        {
            return students;
        }

    }
    
}
