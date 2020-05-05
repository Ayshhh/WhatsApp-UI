using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Aysha.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
            protected override void OnAppearing()
        {
            base.OnAppearing();

            List<ListItem> listItems = new List<ListItem>();
            ListItem listItem = new ListItem() { Name = "Aysha" , Picture ="Icon.png" };
            ListItem listItem1 = new ListItem() { Name = "Spencer Hastings" , Picture = "Spencer.png" };
            ListItem listItem2 = new ListItem() { Name = "Hanna Marin", Picture="Hanna.png" };
            ListItem listItem3 = new ListItem() { Name = "Emily", Picture = "Emily.png" };
            ListItem listItem4 = new ListItem() { Name = "Tony stark", Picture = "Tony.png" };
            ListItem listItem5 = new ListItem() { Name = "Aria Montgomery", Picture = "Aria.png" };
            
            ListItem listItem7 = new ListItem() { Name = "Natasha", Picture = "Natasha.png" };
            ListItem listItem8 = new ListItem() { Name = "Wonder women", Picture = "Wonder.png" };
            ListItem listItem9 = new ListItem() { Name = "Robert", Picture = "Robert.png" };
            ListItem listItem10 = new ListItem() { Name = "Sunny Leone", Picture = "Sunny.png" };
            
            ListItem listItem12 = new ListItem() { Name = "Alison Dlaurentis", Picture = "Alison.png" };
            listItems.Add(listItem);
            listItems.Add(listItem1);
            listItems.Add(listItem2);
            listItems.Add(listItem3);
            listItems.Add(listItem4);
            listItems.Add(listItem5);
            
            listItems.Add(listItem7);
            listItems.Add(listItem8);
            listItems.Add(listItem9);
            listItems.Add(listItem10);
            
            listItems.Add(listItem12);
            WhatsApp.ItemsSource = listItems;
        }
    }
    
}