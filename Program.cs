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
        static void Main()
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
        }    
    }
}