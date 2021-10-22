using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.(1,2,3)");
            bool flag = true;
            int count = 0;
            while (flag)
            {
                Console.WriteLine("Введите операцию");
                string operation = Console.ReadLine().ToLower();
                BankAccount bank_account = new BankAccount();
                /*Console.WriteLine("Введите номер банковского счета:");
                long number;
                while(!long.TryParse(Console.ReadLine(), out number)){
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }*/
                long number = BankAccount.UniqNumber();
                Console.WriteLine("Введите баланс банковского счета:");
                decimal balance;
                while (!decimal.TryParse(Console.ReadLine(), out balance))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                bank_account.FillIn(number, balance);
                bank_account.Type();
                if(operation.Equals("положить на счет"))
                {
                    TestPutMoney(bank_account);
                    bank_account.PrintValues();
                }
                else if(operation.Equals("снять со счета"))
                {
                    TestWithdrawMoney(bank_account);
                    bank_account.PrintValues();
                }
                else
                {
                    bank_account.PrintValues();
                }
                //bank_account.PrintValues();
                count++;
                if (count == 3)
                {
                    flag = false;
                }
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Домашнее задание 7.1");
            bool flag1 = true;
            int count1 = 0;
            while (flag1)
            {
                Building building = new Building();
                int number = Building.UniqNumber();
                Console.WriteLine("Введите высоту здания");
                int height;
                while(!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во этажей в здании");
                int count_floors;
                while (!int.TryParse(Console.ReadLine(), out count_floors))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во квартир в здании");
                int count_apat;
                while (!int.TryParse(Console.ReadLine(), out count_apat))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во подъездов в здании");
                int count_entr;
                while (!int.TryParse(Console.ReadLine(), out count_entr))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                building.FillIn(number, height, count_floors, count_apat, count_entr);
                building.PrintValues();
                count++;
                if (count1 == 3)
                {
                    flag1 = false;
                }
            }
            Console.ReadKey();
        }
        public static void TestPutMoney(BankAccount acc)
        {
            Console.WriteLine("Введите сумму");
            decimal sum;
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            acc.PutMoney(sum);
        }
        public static void TestWithdrawMoney(BankAccount acc)
        {
            Console.WriteLine("Введите сумму");
            decimal sum;
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            if (!acc.WithdrawMoney(sum))
            {
                Console.WriteLine("Невозможно снять данную сумму денег");
            }
        }
    }
}
