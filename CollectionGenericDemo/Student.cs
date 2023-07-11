using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericDemo
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string StudentClass { get; set; }

        public int StudentAge { get; set;}

        public string StudentGender { get; set;}

        public int StudentPhone { get; set;}

        public string StudentAddress { get; set; }

    }


    public class StudentCRUD
    {
        private List<Student> students;

        public StudentCRUD()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student stu)
        {
            students.Add(stu);   
        }

        public List<Student> GetStudent()
        {
            return students; 
        }

        public void UpdateStudent(Student stu)
        {
            foreach (Student s in students)
            {
                if (s.StudentId == stu.StudentId)
                {
                   s.StudentName = stu.StudentName;
                    s.StudentClass = stu.StudentClass;
                    s.StudentGender = stu.StudentGender;
                    s.StudentAge = stu.StudentAge;
                    s.StudentAddress = stu.StudentAddress;
                    s.StudentPhone = stu.StudentPhone;
                    break;
                }
            }
        }

        public void DeleteStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s.StudentId == id)
                {
                    students.Remove(s);
                    break;
                }
            }
        }


    }
}
