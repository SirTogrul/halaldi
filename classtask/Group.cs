using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Group
    {
        public int GroupNo { get; set; }
        public Student[] Students = { };

        public int StudentLimit
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (StudentLimit > 5 && StudentLimit < 18)
                {
                    StudentLimit = value;
                }
            }
        }
        public void AddStudent(Student student)
        {


            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Sizin ucun ayrilan limiti kecmisiniz");
            }

        }
        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public void GetAllStudent()
        {
            Console.WriteLine(Students);
        }
        public void CheckGroupNo(string groupNo)
        {
          bool check = false;
           
            if (groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0])) check = true;
                if (char.IsUpper(groupNo[1])) check = true;
                if (char.IsDigit(groupNo[2])) check = true;
                if (char.IsDigit(groupNo[3])) check = true;
                if (char.IsDigit(groupNo[4])) check = true;
            }
            else
            {
                Console.WriteLine("Qrupun adi duzgun daxil edilmemisdir");
            }

        }
    }
}
