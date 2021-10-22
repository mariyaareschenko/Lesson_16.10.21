using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_7
{
    enum Transport {bus_56, metro, train_3}
    class MuslimCemetery : Cemetery
    {
        private double grave_size;
        private string schedule;
        private string type;
        public double GraveSize
        {
            get
            {
                return grave_size;
            }
            private set { }
        }
        public string Schedule
        {
            get
            {
                return schedule;
            }
            private set { }
        }
        public string Type
        {
            get
            {
                return type;
            }
            private set { }
        }

        public MuslimCemetery(double territory, int count_graves, double grave_size) : base(territory, count_graves)
        {
            this.grave_size = grave_size;
        }
        public MuslimCemetery(double territory, int count_graves, string type) : base(territory, count_graves)
        {
            type = File.ReadAllText(@"Muslim.txt");
            this.type = type;
            Console.WriteLine(type);
        }
        public string Visit(string schedule)
        {
            schedule = File.ReadAllText(@"schedule.txt");
            this.schedule = schedule;
            return schedule;
        }
        public double PossibleGraves(double territory, int count_graves, double grave_size)
        {
            double possible_graves;
            double occupied_place = count_graves * grave_size;
            if (territory - occupied_place > 0)
            {
                double free_place = territory - occupied_place;
                possible_graves = Math.Round(free_place / grave_size);
            }
            else if(grave_size == 0)
            {
                possible_graves = 0;
                Console.WriteLine("Error");
            }
            else
            {
                possible_graves = 0;
                Console.WriteLine("There is no free space in the cemetery");
            }
            return possible_graves;
        }
        public void Route(string district)
        {
            Transport transport = new Transport();
            if (district.Length <= 8)
            {
                transport = Transport.bus_56;
                Console.WriteLine($"You can drive to the cemetery by {transport}");
            }
            else if(district.Length > 8 && district.Length <= 12)
            {
                transport = Transport.metro;
                Console.WriteLine($"You can drive to the cemetery by {transport}");
            }
            else if (district.Length > 12)
            {
                transport = Transport.train_3;
                Console.WriteLine($"You can drive to the cemetery by {transport}");
            }
        }
        public override void PrintVal()
        {
            Console.WriteLine($"Сemetery opening hours:\n{Visit("i")}\nСemetery size: {this.Territory}, number of graves: {this.Count_Graves}");
        }
    }
}
