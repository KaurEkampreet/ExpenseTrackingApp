using ExpenseTrackingApp.Model;
using System;
using System.Collections.Generic;
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
        public AddExpenses()
        {
            InitializeComponent();

            //MainLabel.Text = parameter;
        }

        public string Budget { get; internal set; }

        //protected override void OnAppearing()
        //{
        //    //base.OnAppearing();

        //    //string x = (Expenses.Budget).ToString();

        //    //BudgetAm = decimal.Parse(budget.Text);
        //}

        private async void AddExpensesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ExpenseCategories
            {
                //BindingContext = new Expenses()
            });
        }
    }
}