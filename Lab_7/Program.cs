using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the cemetery");
            double size_cemetry;
            while(!double.TryParse(Console.ReadLine(), out size_cemetry))
            {
                Console.WriteLine("Error, please try again");
            }
            Console.WriteLine("Enter the number of graves");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Error, please try again");
            }
            Console.WriteLine("Enter the size of one grave");
            double size;
            while (!double.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Error, please try again");
            }
            Console.WriteLine("Enter the type of cemetery");
            string type = Console.ReadLine().ToLower();
            if (type.Equals("christian"))
            {
                ChristianСemetery christianСemetery = new ChristianСemetery(size_cemetry, count, "i");
                christianСemetery = new ChristianСemetery(size_cemetry, count, size);
                christianСemetery.PrintVal();
                Security security = new Security("John", 37, 4);
                security.Print();
                security.WorkShift("John", 37);
                Console.WriteLine("What do you want to know: the amount of free space; the list of attendance");
                string str = Console.ReadLine().ToLower();
                if(str.Equals("free space"))
                {
                    christianСemetery.FreePlace(size_cemetry, count, size);
                }
                else if (str.Equals("attendance"))
                {
                    christianСemetery.Visit("i");
                }
                else
                {
                    Console.WriteLine("No entered operation");
                }
            }
            else if (type.Equals("muslim"))
            {
                MuslimCemetery muslimCemetery = new MuslimCemetery(size_cemetry, count, "i");
                muslimCemetery = new MuslimCemetery(size_cemetry, count, size);
                muslimCemetery.PrintVal();
                Security security = new Security("Ali", 56, 10);
                security.Print();
                security.WorkShift("Ali", 56);
                Console.WriteLine("What do you want to know: how can you get to the cemetery; how many graves still fit");
                string str = Console.ReadLine().ToLower();
                if (str.Equals("number of graves to fit"))
                {
                    double possible_graves = muslimCemetery.PossibleGraves(size_cemetry, count, size);
                    Console.WriteLine(possible_graves);
                }
                else if(str.Equals("get to the cemetery"))
                {
                    Console.WriteLine("Which area do you want to get from?");
                    string district = Console.ReadLine().ToLower();
                    muslimCemetery.Route(district);
                }
                else
                {
                    Console.WriteLine("No entered operation");
                }
            }
            else
            {
                Console.WriteLine("Sorry, there is no such cemetery");
            }
            Console.ReadKey();
        }
    }
}
