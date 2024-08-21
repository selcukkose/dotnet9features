
using ConsoleApp1.Features.Interfaces;

namespace ConsoleApp1.Features;
public class LockEx : IFeature
{
    private double _currentBalance;
    private readonly Lock _lockObj = new();
    private void Deposit(double amount)
    {
        _currentBalance += amount;
    }
    
    private void Withdraw(double amount)
    {
        _currentBalance -= amount;
    }
    
    public void Run()
    {
        var t1 = new Thread(() =>
        {
            for (var i = 0; i < 1000; i++)
            {
                using (_lockObj.EnterScope())
                {
                    Deposit(110);
                }
            }
        });
        
        var t2 = new Thread(() =>
        {
            for (var i = 0; i < 1000; i++)
            {
                using (_lockObj.EnterScope())
                {
                    Withdraw(100);
                }
            }
        });
        
        t1.Start();
        t2.Start();
        
        t1.Join();
        t2.Join();
        
        Console.WriteLine(_currentBalance);
    }
}

