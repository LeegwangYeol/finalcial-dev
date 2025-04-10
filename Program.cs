using System;
using System.Windows.Forms;
using Financial;

namespace finalcial_app
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // 콘솔 출력 인코딩을 UTF-8로 설정
Console.OutputEncoding = System.Text.Encoding.UTF8;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Financial.Financial());
            Calculate calculate = new Calculate();
            calculate.Execute();
            Console.WriteLine("\n");
            // Calculate calculate2 = new Calculate();
            // calculate2.Execute();
            
            Anmous anmous = new Anmous();
            anmous.Execute();

            //아래는 패턴 일치의 예제임
            int? maybe = 12;
            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }
        
        
            PatternTest patternTest = new PatternTest();
            // await Task.Run(() => patternTest.ExecuteAsyncMethods());
            // 메인 흐름과 별개로 비동기로 실행하고 결과를 무시합니다 (fire-and-forget 패턴)
            // _ = Task.Run(() => patternTest.ExecuteAsyncMethods());
            // patternTest.Execute();

            Console.WriteLine("\n");
            TuffleTest tuffleTest = new TuffleTest();
            tuffleTest.Execute();

            Console.WriteLine("\n testfor LINQ");

            TestForLinq testForLinq = new();
            testForLinq.Test();
        }
    }
}