using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
            actions.Add(() => Console.WriteLine(i));
        }

        foreach (var action in actions)
        {
            action();
        }
        Console.ReadKey();
    }
}