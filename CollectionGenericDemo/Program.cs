using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericDemo
{
    public class Program
    {
        // using collections CRUD(C- Create/Insert/ Add, R- Read / Display/Get, U-Update/Modify, D-Delete/Remove) operation

        static void Main(string[] args)
        {
            /**********Student*******************/
            StudentCRUD crud = new StudentCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Display Student Details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Add Student
                        Student s1 = new Student();
                        Console.WriteLine("Enter Student Id");
                        s1.StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s1.StudentName = Console.ReadLine();
                        Console.WriteLine("Enter Student class");
                        s1.StudentClass= Console.ReadLine();
                        Console.WriteLine("Enter Student Age");
                        s1.StudentAge =Convert.ToInt32( Console.ReadLine());
                        Console.WriteLine("Enter Student Gender");
                        s1.StudentGender=Console.ReadLine();
                        Console.WriteLine("Enter Student Address");
                        s1.StudentAddress= Console.ReadLine();
                        Console.WriteLine("Enter Student Phone");
                        s1.StudentPhone=Convert.ToInt32( Console.ReadLine());


                        crud.AddStudent(s1);
                        break;

                    case 2:
                        //Update Student
                        Student s2 = new Student();
                        Console.WriteLine("Enter id to modify");
                        s2.StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s2.StudentName = Console.ReadLine();
                        Console.WriteLine("Enter Student class");
                        s2.StudentClass = Console.ReadLine();
                        Console.WriteLine("Enter Student Age");
                        s2.StudentAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Gender");
                        s2.StudentGender = Console.ReadLine();
                        Console.WriteLine("Enter Student Address");
                        s2.StudentAddress = Console.ReadLine();
                        Console.WriteLine("Enter Student Phone");
                        s2.StudentPhone = Convert.ToInt32(Console.ReadLine());

                        crud.UpdateStudent(s2);
                        break;

                    case 3:

                        //Delete Student
                        Console.WriteLine("Enter id to delete:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        crud.DeleteStudent(id);
                        break;

                    case 4:

                        //Display Student

                        List<Student> list = crud.GetStudent();
                        foreach (Student s in list)
                        {
                            Console.WriteLine($"Student ID: {s.StudentId}\nStudent Name:{s.StudentName}\n " +
                                $"Student Class:{s.StudentClass}\nStudent Age{s.StudentAge}\nStudent Adress{s.StudentAddress}\nStudent Phone{s.StudentPhone}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 for continue:");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }














        //    /**********Employee*******************/
        //    EmployeeCRUD crud = new EmployeeCRUD();
        //    int option = 0;
        //    do
        //    {
        //        Console.WriteLine("1. Add Employee");
        //        Console.WriteLine("2.Update Employee");
        //        Console.WriteLine("3. Delete Employee");
        //        Console.WriteLine("4. Display Employee Details");
        //        int op = Convert.ToInt32(Console.ReadLine());

        //        switch (op)
        //        {
        //            case 1:
        //                //Add Employee
        //                Employee e1 = new Employee();
        //                Console.WriteLine("Enter Employee Id");
        //                e1.EmpId = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("Enter Employee Name");
        //                e1.EmpName = Console.ReadLine();
        //                Console.WriteLine("Enter Employee salary");
        //                e1.EmpSalary = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine("Enter Employee Designation");
        //                e1.EmpDesignation=Console.ReadLine();

        //                crud.AddEmployee(e1);
        //                break;

        //            case 2:
        //                //Update Employee
        //                Employee e2 = new Employee();
        //                Console.WriteLine("Enter id to modify");
        //                e2.EmpId = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("Enter Employee Name");
        //                e2.EmpName = Console.ReadLine();
        //                Console.WriteLine("Enter Employee salary");
        //                e2.EmpSalary = Convert.ToDouble(Console.ReadLine());
        //                Console.WriteLine("Enter Employee Designation");
        //                e2.EmpDesignation=Console.ReadLine();

        //                crud.UpdateEmployee(e2);
        //                break;

        //            case 3:

        //                //Delete Employee
        //                Console.WriteLine("Enter id to delete:");
        //                int id = Convert.ToInt32(Console.ReadLine());

        //                crud.DeleteEmployee(id);
        //                break;

        //            case 4:

        //                //Display Employee

        //                List<Employee> list = crud.GetEmployees();
        //                foreach (Employee e in list)
        //                {
        //                    Console.WriteLine($"Employee ID: {e.EmpId}\nEmployee Name:{e.EmpName}\n Employee Salary:{e.EmpSalary}\nEmployee Designation{e.EmpDesignation}");
        //                }
        //                break;
        //        }
        //        Console.WriteLine("Press 1 for continue:");
        //        option = Convert.ToInt32(Console.ReadLine());
        //    }
        //    while (option == 1);
        //}





        /* **********************Product***********************/

        //ProductCRUD crud = new ProductCRUD();
        //int option = 0;
        //do
        //{
        //    Console.WriteLine("1. Add Product");
        //    Console.WriteLine("2.Update Product");
        //    Console.WriteLine("3. Delete Product");
        //    Console.WriteLine("4. Display Product");
        //    int op=Convert.ToInt32(Console.ReadLine());

        //    switch (op)
        //    {
        //        case 1:
        //            //Add Product
        //            Product p1 = new Product();
        //            Console.WriteLine("Enter Product Id");
        //            p1.Id = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Enter Product Name");
        //            p1.Name = Console.ReadLine();
        //            Console.WriteLine("Enter Product Price");
        //            p1.Price = Convert.ToDouble(Console.ReadLine());

        //            crud.AddProduct(p1);
        //            break;

        //        case 2:
        //            //Update Product
        //            Product p2 = new Product();
        //            Console.WriteLine("Enter id to modify");
        //            p2.Id = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Enter Product Name");
        //            p2.Name = Console.ReadLine();
        //            Console.WriteLine("Enter Product Price");
        //            p2.Price = Convert.ToDouble(Console.ReadLine());

        //            crud.UpdateProduct(p2);
        //            break;

        //        case 3:

        //            //Delete Product
        //            Console.WriteLine("Enter id to delete:");
        //            int id = Convert.ToInt32(Console.ReadLine());

        //            crud.DeleteProduct(id);
        //            break;

        //        case 4:

        //            //Display Product

        //            List<Product> list = crud.GetProducts();
        //            foreach (Product p in list)
        //            {
        //                Console.WriteLine($"Product ID: {p.Id}Produt Name:{p.Name} Product Price:{p.Price}");
        //            }
        //            break;
        //    }
        //    Console.WriteLine("Press 1 for continue:");
        //    option=Convert.ToInt32(Console.ReadLine());
        //}
        //while (option==1);
        //}
    }
}

