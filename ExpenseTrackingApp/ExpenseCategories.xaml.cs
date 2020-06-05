using ExpenseTrackingApp.Model;
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
    public partial class ExpenseCategories : ContentPage
    {
        public DateTime SelectedDate { get; set; }
        public ExpenseCategories()
        {
            InitializeComponent();
              
        }
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
        var expensePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
            LocalApplicationData),
            $"{Path.GetRandomFileName()}.expenses.txt");
        var expenses = new Expenses
        {

            Name = nameLabel.Text,
            Amount = Convert.ToDecimal(amountLabel.Text),
            DateOfPurchase = SelectedDate,
            Category = pickerCategory.SelectedItem.ToString()

        };


        File.WriteAllText(expensePath, expenses.toString());



        await Navigation.PushModalAsync(new AddExpenses
        {

            Budget = File.ReadAllText
           ("data/user/0/com.companyname.expensetrackingapp/files/.local/share/ExpenseBudget.txt")


        });

        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {

        }

        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            SelectedDate = e.NewDate;

        }

    }
}