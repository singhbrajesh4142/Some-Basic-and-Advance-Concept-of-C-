using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeadlockInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started !");
            Account AccountA = new Account(101, 5000);
            Account AccountB = new Account(102, 6000);

            AccountManager AccountManagerA = new AccountManager(AccountA, AccountB, 1000);
            Thread T1 = new Thread(AccountManagerA.Transfer);
            T1.Name = "T1";

            AccountManager AccountManagerB = new AccountManager(AccountB, AccountA, 2000);
            Thread T2 = new Thread(AccountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("Main Completed !");
        }
    }

    public class Account
    {
        double _balance; int _id;
        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }

        public int ID
        {
            get { return this._id; }
        }

        public void WithDraw(double amount)
        {
            this._balance -= amount;
        }
        public void Deposit(double amount)
        {
            this._balance += amount;
        }
    }

    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _ammountToTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double ammountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._ammountToTransfer = ammountToTransfer;
        }
        public void Transfer()
        {
            object _lock1, _lock2;
            if(_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount; _lock2 = _toAccount;
            }else
            {
                _lock1 = _toAccount; _lock2 = _fromAccount;
            }
            Console.WriteLine(Thread.CurrentThread.Name + " trying to accuire lock on " + ((Account)_lock1).ID.ToString() );
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Aquired lock on " + ((Account)_lock1).ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second ");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to aquire lock on " + ((Account)_lock2).ID.ToString());
                lock (_toAccount)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " aquired lock on " + ((Account)_lock2).ID.ToString());
                    _fromAccount.WithDraw(_ammountToTransfer);
                    _toAccount.Deposit(_ammountToTransfer);
                }
            }
        }
    }
}
