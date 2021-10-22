using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_7
{
    class ChristianСemetery : Cemetery
    {
        private string attendance;
        private double grave_size;
        private string type;
        public double GraveSize
        {
            get
            {
                return grave_size;
            }
            private set {}
        }
        public string Attendance
        {
            get
            {
                return attendance;
            }
            private set {}
        }
        public string Type
        {
            get
            {
                return type;
            }
            private set { }
        }
        public ChristianСemetery(double territory, int count_graves, string type) : base(territory, count_graves)
        {
            type = File.ReadAllText(@"Christian.txt");
            this.type = type;
            Console.WriteLine(type);
        }
        public ChristianСemetery(double territory, int count_graves, double grave_size):base(territory, count_graves)
        {
            this.grave_size = grave_size;            
        }
        public void Visit(string attendance)
        {
            attendance = File.ReadAllText(@"attendance_christ.txt");
            this.attendance = attendance;
            Console.WriteLine($"The number of people who visited the cemetery:\n{this.Attendance}");
        }
        public void FreePlace(double territory, int count_graves, double grave_size)
        {
            double free_place;
            double occupied_place = count_graves * grave_size;
            if (territory - occupied_place > 0)
            {
                free_place = territory - occupied_place;
                Console.WriteLine($"There is a free space in the cemetery: {free_place} square yard");
            }
            else
            {
                Console.WriteLine("There is no free space in the cemetery");
            }
        }
        public bool Tree(int count_graves)
        {
            if (count_graves % 2 == 0)
                return true;
            else
                return false;
        }

        public override void PrintVal()
        {
            if(Tree(Count_Graves))
            Console.WriteLine($"Сemetery size: {this.Territory}, number of graves: {this.Count_Graves}. The graves have trees");
            else
                Console.WriteLine($"Сemetery size: {this.Territory}, number of graves: {this.Count_Graves}. Graves have no treess");
        }
    }
}
