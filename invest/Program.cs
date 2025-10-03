using invest.Data;
using invest.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace invest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManagement.ReadFileData();

           // Thread.Sleep(-1);
            var app = new Interface();
            app.Run();


        }
    }
}
