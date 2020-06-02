using ExpenseTrackingApp.Model;
using Microsoft.Azure.WebJobs.Host.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpenseTrackingApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var expenseBudgetPath = Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
               "ExpenseBudget.txt");
            File.WriteAllText(expenseBudgetPath, budget.Text);

            await Navigation.PushModalAsync(new AddExpenses
            {
                Budget = budget.Text
            });

        }    
     
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            //var delete = (Expenses)BindingContext;
            //if (File.Exists(delete.Filename))
            //{
            //    File.Delete(delete.Filename);
            //}
            //await Navigation.PopModalAsync();
        }
    }
}
