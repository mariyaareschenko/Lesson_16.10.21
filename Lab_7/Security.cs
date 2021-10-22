using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    enum Shift {night, day}
    class Security
    {
        private string name;
        private int age;
        private int experience;

        public Security(string name, int age, int experience)
        {
            FiilIn(name, age, experience);
        }
        public void FiilIn(string name, int age, int experience)
        {
            this.name = name;
            this.age = age;
            this.experience = experience;
        }
        public void WorkShift(string name, int age)
        {
            Shift shift = new Shift();
            if(age < 60)
            {
                shift = Shift.night;
                Console.WriteLine($"The security {name} guard works the {shift} shift"); 
            }
            else
            {
                shift = Shift.day;
                Console.WriteLine($"The security {name} guard works the {shift} shift");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Security: {name}, {age} years old. Work experience: {experience} years");
        }
    }
}
