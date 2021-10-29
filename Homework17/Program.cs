using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount<string> account1 = new BankAccount<string>();

                Console.Write("Введите номер банковского счета: ");
                account1.IdAccount = Console.ReadLine();
                Console.Write("Имя владельца банковского счета: ");
                account1.Name = Console.ReadLine();
                Console.Write("Баланс равен: ");
                account1.Balance = Convert.ToDouble(Console.ReadLine());

                BankAccount<ulong> account2 = new BankAccount<ulong>();
                Console.Write("Введите номер банковского счета: ");
                account2.IdAccount = (ulong)Convert.ToInt64(Console.ReadLine());
                Console.Write("Имя владельца банковского счета: ");
                account2.Name = Console.ReadLine();
                Console.Write("Баланс равен: ");
                account2.Balance = Convert.ToDouble(Console.ReadLine());
                account1.Print(account1.Balance, account1.Name, account1.IdAccount);
                account2.Print(account2.Balance, account2.Name, account2.IdAccount);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода.");
                Console.ReadKey();
                return;
            }


        }
    }
    class BankAccount<T>
    {
        T idAccount;
        double balance;
        string name;
        public T IdAccount
        {
            set
            {
                idAccount = value;
            }
            get
            {
                return idAccount;
            }
        }
        public double Balance
        {
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            get
            {
                return balance;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public void Print(double balance, string name, T idAccount)
        {
            Console.WriteLine("Имя: {0}. Баланс: {1}. Номер счета: {2}.", name, balance, idAccount);
        }
    }

}

