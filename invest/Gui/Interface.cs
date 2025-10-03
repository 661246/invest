using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace invest.Gui
{
    internal class Interface
    {
        private Window win;
        private Label contentLabel;

        public void Run()
        {
            Application.Init();

            try
            {
                var top = Application.Top;

                win = new Window("Transtocksions")
                {
                    X = 0,
                    Y = 1,
                    Width = Dim.Fill(),
                    Height = Dim.Fill()
                };

                var header = new Label("Transtocksions - Stock & Portfolio Investment Manager")
                {
                    X = Pos.Center(),
                    Y = 0,
                    ColorScheme = Colors.Base
                };
                win.Add(header);

                var menu = CreateMenuBar();

                contentLabel = new Label("Select a menu option to get started...")
                {
                    X = Pos.Center(),
                    Y = Pos.Center(),
                };
                win.Add(contentLabel);

                top.Add(menu, win);
                Application.Run();
            }
            finally
            {
                Application.Shutdown();
            }
        }

        private MenuBar CreateMenuBar()
        {
            return new MenuBar(new MenuBarItem[]
            {
            new MenuBarItem("_File", new MenuItem[]
            {
                new MenuItem("_Dividends", "", () => OnExample1()),
                new MenuItem("_Transactions", "", () => OnExample2()),
                new MenuItem("_Portfolio Allocation", "", () => OnExample3()),
                null, // Separator
                new MenuItem("_Quit", "", () => Application.RequestStop())
            })
            });
        }

        private void OnExample1()
        {
            ShowDialog("Example 1", "You selected Example 1!");
        }

        private void OnExample2()
        {
            ShowDialog("Example 2", "You selected Example 2!");
        }

        private void OnExample3()
        {
            ShowDialog("Example 3", "You selected Example 3!");
        }

        private void ShowDialog(string title, string message)
        {
            MessageBox.Query(title, message, "OK");
        }
    }
}
