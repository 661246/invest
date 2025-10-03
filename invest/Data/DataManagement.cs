using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace invest.Data
{
    class Stock
    {
        public string name;
        public double amount;
        public double stockPrice;

        public Stock(string name1, double amount1, double stockPrice1)
        {
            this.name = name1;
            this.amount = amount1;
            this.stockPrice = stockPrice1;
        }
    };

    internal class DataManagement
    {
        static List<Stock> stocks = new List<Stock>();

        public static void ReadFileData()
        {
            // czytanie danych z pliku
            string filePath = "./stockdata.txt";
            // format pliku - transcation type; stockname; stockPrice; amount; date

            foreach (var item in File.ReadAllLines(filePath))
            {
                string[] lines = item.Split(',');

                // name, amount, price
               

                // loop ove rthe stocks array and see if that exists,
                // otherwise add; else add the anmount or minus the amount
                stocks.ForEach((stock) => { 
                    if(stock.name == lines[1] && lines[0] == "BUY")
                    {
                        stock.amount += Double.Parse(lines[3]);
                    } else if (stock.name == lines[1] && lines[0] == "SELL")
                    {
                        stock.amount -= Double.Parse(lines[3]);
                    } else
                    {
                        Stock newStock = new Stock(lines[1], Double.Parse(lines[3]), Double.Parse(lines[2]));
                        stocks.Add(newStock);
                    }
                });


                
            };
        }
    }
}
