using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           //string filepath="C:\\Users\\hamma\\Desktop\\students.txt";
            //string []arg =new string [0];
            //arg[0]=filepath;
            char ch;
           do
           {
               
               String choose;
            Console.WriteLine("\t\t\t\t\tWelcome To The Student Profile System\t\t\t");
            Console.WriteLine("Press 1: Creating File");
            Console.WriteLine("Press 2: Create Student Profile");
            Console.WriteLine("Press 3: Search Student By ID");
            Console.WriteLine("Press 4: Search Student By Name");
            Console.WriteLine("Press 5: Delete Student Record");
            Console.WriteLine("Press 6: List Top of 3 Students");
            Console.WriteLine("Press 7: Mark Student Attendance");
            Console.WriteLine("Press 8: View Student Attendance");
            choose = Console.ReadLine();
            
            StudentProfile obj = new StudentProfile();
            switch (choose)
            {
                case "1":
                    {
                        obj.createfile();
                        break;
                    }
                case"2":
                    {
                        break;
                    }
                case"3":
                    {
                        obj.SearchingByID();
                        break;
                    }
                case"4":
                    {
                        obj.SearchByName();
                        break;
                    }
                case "5":
                    {
                        obj.deleteStudent();
                        break;
                    }
                case "6":
                    {
                        
                        break;
                    }
                case"7":
                    {
                        obj.attendance();
                        break;
                    }
                case"8":
                    {
                        obj.viewAttendance();
                        break;
                    }
            }
            Console.WriteLine("IF You Want back To The Main Manu Press Y");
            ch = char.Parse(Console.ReadLine());
          
           
           
        }while(ch=='y'||ch=='Y');
        Console.ReadLine();
    }
         
    }
}
class StudentProfile
{
    string filepath = "C:\\Users\\hamma\\Desktop\\students.txt";
    String name, name1;
    String ID, ID2;
    String Department, Department1;
    String University, University1;
    String Semester, Semester1;
    float CGPA, CGPA1;


    public void createfile()
    {
        FileStream fs = new FileStream("C:\\Users\\hamma\\Desktop\\students.txt", FileMode.Append);
        StreamWriter obj1 = new StreamWriter(fs);
        Console.WriteLine("Please enter the ID of a Student");
        ID = Console.ReadLine();
        obj1.WriteLine(ID);

        Console.WriteLine("Please enter the name of the student");
        name = Console.ReadLine();
        obj1.WriteLine(name);
        Console.WriteLine("please enter the Cgpa of the student");
        CGPA = float.Parse(Console.ReadLine());
        obj1.WriteLine(CGPA);
        Console.WriteLine("please enter the Department of the student");
        Department = Console.ReadLine();
        obj1.WriteLine(Department);
        Console.WriteLine("Please enter the University of the student");
        University = Console.ReadLine();
        obj1.WriteLine(University);
        Console.WriteLine("Please enter the Semester of the student");
        Semester = (Console.ReadLine());
        obj1.WriteLine(Semester);
        obj1.Close();
    }
     public void deleteStudent()
     {
         String StudentId;
         Console.WriteLine("Kindly please Enter the ID");
         StudentId = Console.ReadLine();
         int index = 0;
         string[] num2 = new string[20];
         String[] array1 = new string[50];
         string[] name = new string[500];
         int d = 0;
         StreamReader read = new StreamReader("C:\\Users\\hamma\\Desktop\\students.txt");
         do
         {
             array1[index] = read.ReadLine();
             index++;
         }

         while (!read.EndOfStream);
         for (int i = 0; i < index; i++)
         {
             if (StudentId == array1[i])
             {
                 Console.WriteLine("deleted");
                 i = i + 5;
             }
             else
             {
                 num2[d] = array1[i];
                 d++;
             }
         }
         read.Close();
         StreamWriter write = File.CreateText("C:\\Users\\hamma\\Desktop\\students.txt");
         for (int i = 0; i < index; i++)
         {
             write.WriteLine(num2[i]);
         }
         write.Close();
     }
     public void attendance()
    {
        FileStream fs = new FileStream("C:\\Users\\hamma\\Desktop\\students.txt", FileMode.Open);
        StreamReader obj2 = new StreamReader(fs);
        Console.WriteLine("please enter the Id");
        ID = Console.ReadLine();
        string num;
        while ((num = obj2.ReadToEnd()) != null)
        {
            if (num.Contains(ID))
            {
                Console.WriteLine("found");
                break;
            }
            else
            {
                Console.WriteLine("not found");
                break;
            }
            obj2.Close();
        }
        StreamWriter obj = File.AppendText("C:\\Users\\hamma\\Desktop\\attendance.txt");
        obj.WriteLine(ID);
        obj.Close();
        Console.WriteLine("Enter Your Choice P/A");
        string p = Console.ReadLine();
        StreamWriter obj1 = File.AppendText("C:\\Users\\hamma\\Desktop\\attendance.txt");
        obj1.WriteLine(p);
        obj1.Close();

    }
    public void viewAttendance()
    {

        StreamReader obj = File.OpenText("C:\\Users\\hamma\\Desktop\\attendance.txt");
        do
        {
            obj.ReadLine();
            Console.WriteLine(obj.ReadLine());
            
        } while (!obj.EndOfStream);
        obj.Close();
    }
    public void SearchingByID()
    {
        StreamReader obj2 = File.OpenText("C:\\Users\\hamma\\Desktop\\students.txt");
        String input;
        Console.WriteLine("please enter the id");
        input = Console.ReadLine();
        do
        {
            if (obj2.ReadLine() == input)
            {
                Console.WriteLine("Record found");
                Console.WriteLine("name:" + obj2.ReadLine());
                Console.WriteLine("GPA:" + obj2.ReadLine());
                Console.WriteLine("University:" + obj2.ReadLine());
                Console.WriteLine("Deaprtment:" + obj2.ReadLine());
                Console.WriteLine("Semester:" + obj2.ReadLine());
            }
            else
            {
                Console.WriteLine("Sorry Record Is Not Found");
                break;
            }
        } while (!obj2.EndOfStream);
        obj2.Close();
    }
    public void SearchByName()
    {
        StreamReader obj2 = File.OpenText("C:\\Users\\hamma\\Desktop\\students.txt");
        String input;
        Console.WriteLine("please enter the id");
        input = Console.ReadLine();
        do
        {
            String num, k;
            if (obj2.ReadLine() == input)
            {
                Console.WriteLine("Record found");
                Console.WriteLine("GPA:" + obj2.ReadLine());
                Console.WriteLine("University:" + obj2.ReadLine());
                Console.WriteLine("Deaprtment:" + obj2.ReadLine());
                Console.WriteLine("Semester:" + obj2.ReadLine());
            }
            else
            {
                Console.WriteLine("Sorry Record Is Not Found");
            }
} while (!obj2.EndOfStream);
    }
    }
        



