﻿using ExpenseTrackingApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTrackingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExpenses : ContentPage
    {
        public string Budget { get; set; }

        public AddExpenses()
        {
            InitializeComponent();
            //to delete expense files

            //var files = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "*.expenses.txt");
            //foreach (var dataFile in files)
            //{
            //    File.Delete(dataFile);
            //}
        }

        protected override void OnAppearing()
        {
            decimal totalSum = 0;
            BudgetLabel.Text = $"BudgetExpense is {Budget}";

            var expenseDataFiles = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "*.expenses.txt").ToList();

            var expenses = new List<Expenses>();

            foreach (var dataFile in expenseDataFiles)
            {
                //fruits \n 10 \n food
                //File.Delete(dataFile);
                //continue;
                var data = File.ReadAllText(dataFile);
                string[] dataSplit = data.Split('\n');


                var expense = new Expenses
                {
                    Name = dataSplit[0],
                    Amount = Convert.ToDecimal(dataSplit[1]),
                    Category = dataSplit[2],
                    DateOfPurchase = Convert.ToDateTime(dataSplit[3]),
                    CategoryIcon = Expenses.CATEGORY_URL_MAP[dataSplit[2]]
                };

                expenses.Add(expense);
                totalSum = totalSum + expense.Amount;
            }
            decimal remainingAmount = Convert.ToDecimal(Budget) - totalSum;

           RemainingAmountLabel.Text = $"Remaining Amount is {remainingAmount}";
            listview.ItemsSource = expenses;
        }

        private async void AddExpensesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ExpenseCategories
            {
                BindingContext = new Expenses()
            });
        }


    }
}