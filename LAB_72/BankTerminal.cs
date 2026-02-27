using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankTerminal
{
    public event Action<int> OnMoneyWithdraw;
    public void Withdraw(int amount)
    {
        OnMoneyWithdraw?.Invoke(amount);
    }
}