using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
            BankTerminal terminal = new BankTerminal();
            terminal.OnMoneyWithdraw += amount => Console.WriteLine($"Знято {amount} грн");
            terminal.Withdraw(100);
            Console.ReadKey();
        }
    }
