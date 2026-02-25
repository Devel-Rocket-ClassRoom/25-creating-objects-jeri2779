using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 계좌 개설 ===");
BankAccount ba = new BankAccount("1001","홍길동",100000);
BankAccount ba2 = new BankAccount("1002","이순신",50000);
BankAccount.ShowTotalAccounts();

Console.WriteLine("=== 거래 ===");
ba.Deposit(50000);
ba2.Deposit(30000);
ba.Withdraw(200000);
ba.Withdraw(100000);

Console.WriteLine("=== 최종 계좌 정보 ===");
ba.ShowInfo();
ba2.ShowInfo();


class BankAccount
{
    public static int TotalAccounts = 0;
    public string AccountNumber;
    public string OwnerName;
    public int Balance;


    public BankAccount(string accountNumber, string ownerName, int balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
        TotalAccounts++;
        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설되었습니다.");
    }


    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"[{AccountNumber}]{amount}원 입금 완료. 잔액: {Balance}원");
        }
        else
        {
            Console.WriteLine("입금 금액은 0보다 커야 합니다.");
        }
    }
    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
        }
        else  
        {
            Balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}원");
        }
    }
    public static void ShowTotalAccounts()
    {
        
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"계좌 번호: {AccountNumber} 예금주: {OwnerName} 잔액: {Balance}원");
    }

}
