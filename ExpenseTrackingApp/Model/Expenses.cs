using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackingApp.Model
{
    public class Expenses
    {
        public string FileName { get; set; }
        public static decimal Budget { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string Category { get; set; }
        public string ImageFile { get; set; }

        public string toString()
        {
            return $"{Name}\n{Amount}\n{Category}\n{DateOfPurchase}";
        }

    }
}
