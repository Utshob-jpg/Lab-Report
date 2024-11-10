using System;
public class BankAccount
{
  string Name;
  double Balance;
  public BankAccount(string _name,double _balance)
  {
    Name=_name;
    Balance=_balance;
  }
  public void Print()
  {
    Console.WriteLine("Acc Name:"+ Name);
     Console.WriteLine("Acc Balance:$"+ Balance);
  }
  static void Main()
  {
    BankAccount b1=new BankAccount("Antoreep", 1000);
  b1.Print();
   BankAccount b2=new BankAccount("Lam", 500);
    BankAccount b3=new BankAccount("Struty", 5000);
    b3.Print();
     BankAccount b4=new BankAccount("Utso", 00);
  }
}
