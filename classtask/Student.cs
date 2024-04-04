using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Student
    {
        public int Id { get; set; }
        private static int _id;
        public string FullName { get; set; }
        public double Point
        {
            get
            {
                return Point;
            }
            set
            {
                if (value < 0)
                {
                    Point=value;
                }
            }
        }
        public Student()
        {
            _id++;
            _id = Id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName}, Point: {Point}");
        }
    }
}
