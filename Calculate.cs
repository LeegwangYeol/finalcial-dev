using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalcial_app
{
    // 금융 거래 인터페이스
    public interface IFinancialTransaction
    {
        string TransactionId { get; }
        decimal Amount { get; }
        DateTime TransactionDate { get; }
        void Execute();
        string GetTransactionDetails();
    }

    // 계좌 인터페이스 
    public interface IAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    public record Model(string Id, string Name, string Email, string Amount, string Status, string Date, string? Avatar);

    // Calculate 클래스에 IAccount 인터페이스 구현
    public class Calculate : IAccount
    {
        public string AccountNumber { get; } = "ACC-123456";
        public decimal Balance { get; private set; } = 1000.00m;

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} 입금 완료. 현재 잔액: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} 출금 완료. 현재 잔액: {Balance:C}");
            }
            else
            {
                Console.WriteLine("잔액 부족");
            }
        }

        // 기존 코드
        public Model alpha;
        public Model beta;
        public Model beta2;
        public Model gamma;

        public Calculate()
        {
            alpha = new Model("1", "Alice Johnson", "alice@example.com", "+$350.00", "success", "2023-07-20", null);
            beta = new Model("2", "Bob Smith", "bob@example.com", "-$120.50", "pending", "2023-07-19", null);
            beta2 = new Model("2", "Bob Smith", "bob@example.com", "-$120.50", "pending", "2023-07-19", null);
            gamma = alpha with { Amount = "+$400.00" };
        }

        public class GenericList<T>
{
    public void Add(T item) { }
}

public class ExampleClass { }

        public void Execute()
        {
            // 인터페이스 사용 예시
            Deposit(500.00m);
            Withdraw(200.00m);
            
            Console.WriteLine(alpha == beta);
            Console.WriteLine(beta == beta2);

            // Create a list of type int.
            GenericList<int> list1 = new();
            list1.Add(1);
            Console.WriteLine(list1);
            // Create a list of type string.
            GenericList<string> list2 = new();
            list2.Add("");
            Console.WriteLine(list2);

            // Create a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new();
            list3.Add(new ExampleClass());
            Console.WriteLine(list3);
        }
    }
}