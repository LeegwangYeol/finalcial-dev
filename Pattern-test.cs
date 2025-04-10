using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace finalcial_app
{
    public class PatternTest
    {
        public record Order(int Items, decimal Cost);
        public decimal CalculateDiscount(Order order) =>
    order switch
    {
        { Items: > 10, Cost: > 1000.00m } => 0.10m,
        { Items: > 5, Cost: > 500.00m } => 0.05m,
        { Cost: > 250.00m } => 0.02m,
        null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
        var someObject => 0m,
    };
    
  public async Task ExecuteAsyncMethods()
{
    // 태스크를 시작하기 전에 콘솔에 메시지 출력
    Console.WriteLine("About to launch a task...");
    
    // Task.Run을 사용하여 별도의 스레드에서 실행될 작업 시작
    // _ = 는 반환된 Task 객체를 무시한다는 의미 (fire-and-forget 패턴)
    _ = Task.Run(() =>
    {
        // 로컬 변수 iterations 선언 및 0으로 초기화
        var iterations = 0;
        
        // int.MaxValue까지 반복하는 매우 긴 루프 시작
        // 이 루프는 CPU를 많이 사용하는 작업을 시뮬레이션함
        for (int ctr = 0; ctr < 10; ctr++)
            iterations++; // 각 반복마다 iterations 변수 증가
            
        // 루프가 완료되면 콘솔에 메시지 출력
        Console.WriteLine("Completed looping operation...");
        
        // 예외를 발생시킴 - 하지만 이 예외는 처리되지 않음
        // 이 예외는 Task가 fire-and-forget 방식으로 실행되어 무시되기 때문에 프로그램 실행에 영향을 주지 않음
        throw new InvalidOperationException();
    });
    
    // 메인 스레드에서 5초 동안 대기
    await Task.Delay(5000);
    
    // 5초 대기 후 콘솔에 메시지 출력하고 메서드 종료
    Console.WriteLine("Exiting after 5 second delay");
}

        public void Execute()
        {
            var a = CalculateDiscount(new Order(12, 1500.00m));
            Console.WriteLine(a);
            var p = new string[] { "John", "Quincy", "Adams", "Boston", "MA" };
            var (first, _, third, _) = (p[0], p[1], p[2], p[3]);
            Console.WriteLine(first);
            Console.WriteLine(third);

            string[] dateStrings = ["05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT"];
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out _))
                    Console.WriteLine($"'{dateString}': valid");
                else
                    Console.WriteLine($"'{dateString}': invalid");
            }


            // 숫자 타입 체크 예제
            var numbers = new object?[] {
                42,                    // int
                3.14,                 // double
                2L,                   // long
                1000000000000000000, // BigInteger
                null
            };


            foreach (var number in numbers)
            {
                var result = number switch
                {
                    int i => $"Integer: {i}",
                    double d => $"Double: {d:F2}",
                    long l => $"Long: {l:N0}",
                    System.Numerics.BigInteger bi => $"BigInteger: {bi:N0}",
                    // null => "Null value",
                    _ => $"Unknown type: null"
                };
                Console.WriteLine(result);

                
            }
        }   
    }
}