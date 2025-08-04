using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Services
{
    public class ConsoleTaskLogger : ITaskLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
