using System;
using System.Collections.Generic;

namespace Online_Stock_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            StockSpanner stockSpanner = new StockSpanner();
            Console.WriteLine(stockSpanner.Next(100));
            Console.WriteLine(stockSpanner.Next(80));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(70));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(75));
            Console.WriteLine(stockSpanner.Next(85));
            Console.WriteLine(stockSpanner.Next(110));
        }
        public class StockSpanner
        {
            Stack<int[]> stocks = new Stack<int[]>();
            public StockSpanner()
            {

            }

            public int Next(int price)
            {
                int counter = 1;
                while (stocks.Count > 0 && stocks.Peek()[0] <= price) counter += stocks.Pop()[1];
                stocks.Push(new int[] { price, counter });
                return counter;
            }
        }
    }
}
