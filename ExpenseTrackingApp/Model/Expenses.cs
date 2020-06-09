using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackingApp.Model
{
    public class Category
    {
        public string CategoryName { get; set; }
        public string Uri { get; set; }
    }
}

//public class ExpenseEntryData
//{
//    public string Budget { get; set; }
//}

public class Expenses
{

    public static string FOOD = "FOOD";
    public static string TRAVEL = "TRAVEL";
    public static string INSURANCE = "INSURANCE";
    public static string UTILITIES = "UTILITIES";
    public static string MISCELLANEOUS = "MISCELLANEOUS";

    public static List<string> CATEGORIES = new List<string>()
    {
        FOOD, TRAVEL, INSURANCE, UTILITIES, MISCELLANEOUS
    };


    public static Dictionary<String, String> CATEGORY_URL_MAP = new Dictionary<String, String>()
        {
            { FOOD, "https://static.thenounproject.com/png/1295369-200.png" },
            { TRAVEL, "https://static.thenounproject.com/png/2079053-200.png" },
            { INSURANCE, "https://static.thenounproject.com/png/2093989-200.png" },
            { UTILITIES , "https://static.thenounproject.com/png/2035509-200.png" },
            { MISCELLANEOUS, "https://static.thenounproject.com/png/3072734-200.png"}
        };

    public string FileName { get; set; }
    public static decimal Budget { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateOfPurchase { get; set; }
    public string Category { get; set; }
    public string CategoryIcon { get; set; }
    public string ImageFile { get; set; }


    public string toString()
    {
        return $"{Name}\n{Amount}\n{Category}\n{DateOfPurchase}";
    }
}
