using LS_DebtApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LS_DebtApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        ObservableCollection<DebtEntry> DebtEntries;

		public MainPage ()
		{
            DebtEntries = new ObservableCollection<DebtEntry>()
            {
                new DebtEntry { Name = "Lars" , Amount=10, Date=DateTime.Now, Reason="Hahahha"},
                new DebtEntry { Name = "Lea" , Amount=-10, Date=DateTime.Now, Reason="Some Reason"},
            };

            InitializeComponent ();

            MyList.ItemsSource = DebtEntries;
		}

        private void OnInfoItemClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InfoPage());
        }

    }
}