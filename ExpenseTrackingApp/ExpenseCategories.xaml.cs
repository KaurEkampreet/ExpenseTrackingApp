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
        public ExpenseCategories()
        {
            InitializeComponent();
        }
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //var expenses = (Expenses)BindingContext;
            //var name = Path.Combine(
            //        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            //        $"{Path.GetRandomFileName()}.expenses.txt");
            //File.WriteAllText(name, editor.Text);

          //  await Navigation.PopModalAsync();
        }


        private void OnCancelButtonClicked(object sender, EventArgs e)
        {

        }
    }
}