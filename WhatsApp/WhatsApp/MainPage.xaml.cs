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
            ListItem listItem = new ListItem() { Name = "Messi" , Picture ="Messi.png" , Chat = "Hey" , Time = "12:50"};
            ListItem listItem1 = new ListItem() { Name = "Spencer Hastings" , Picture = "Spencer.png", Chat = "Hi" , Time = "11:24"};
            ListItem listItem2 = new ListItem() { Name = "Hanna Marin", Picture="Hanna.png", Chat = "Wassup" , Time = "11:00"};
            ListItem listItem3 = new ListItem() { Name = "Emily", Picture = "Emily.png", Chat = "Hahaha", Time = "10:49" };
            ListItem listItem4 = new ListItem() { Name = "Tony stark", Picture = "Tony.png" , Chat = "Busy?", Time = "10:44"};
            ListItem listItem5 = new ListItem() { Name = "Aria Montgomery", Picture = "Aria.png" , Chat = "You?", Time = "10:29" };
            
            ListItem listItem7 = new ListItem() { Name = "Natasha", Picture = "Natasha.png", Chat = "Do I know you?" , Time = "9:42" };
            ListItem listItem8 = new ListItem() { Name = "Wonder women", Picture = "Wonder.png" , Chat = "Lol!" , Time = "7:42" };
            ListItem listItem9 = new ListItem() { Name = "Robert", Picture = "Robert.png", Chat = "There you go" , Time = "5;15"};
            ListItem listItem10 = new ListItem() { Name = "Sunny Leone", Picture = "Sunny.png" , Chat = "Reached?" , Time = "4:20" };
            
            ListItem listItem12 = new ListItem() { Name = "Alison Dlaurentis", Picture = "Alison.png", Chat = "I'm waiting" , Time = "4:00" };
            ListItem listItem13 = new ListItem() { Name = "Beckham", Picture = "Beckham.png" , Chat = "Yeah" , Time = "3:29" };
            ListItem listItem14 = new ListItem() { Name = "Ronaldo", Picture = "Ronaldo.png" , Chat = "Why not?" , Time = "2:10" };
            ListItem listItem15 = new ListItem() { Name = "Neymar", Picture = "Neymar.png" , Chat = "Help needed?" , Time = "1:15"};
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
            listItems.Add(listItem13);
            listItems.Add(listItem14);
            listItems.Add(listItem15);
            WhatsApp.ItemsSource = listItems;

            List<ListItemStatus> Items = new List<ListItemStatus>();
            ListItemStatus Item = new ListItemStatus() { Name1 = "Messi", Pic = "Messi.png", Time1 = "15 minutes ago" };
            ListItemStatus Item1 = new ListItemStatus() { Name1 = "Ronaldo", Pic = "Ronaldo.png", Time1 = "39 minutes ago" };
            ListItemStatus Item2 = new ListItemStatus() { Name1 = "Neymar", Pic = "Neymar.png", Time1 = "56 minutes ago" };
            ListItemStatus Item3 = new ListItemStatus() { Name1 = "Beckham", Pic = "Beckham.png", Time1 = "Today, 5:56" };
            ListItemStatus Item4 = new ListItemStatus() { Name1 = "Alison", Pic = "Alison.png", Time1 = "Today, 3:20" };
            ListItemStatus Item5 = new ListItemStatus() { Name1 = "Tony ", Pic = "Tony.png", Time1 = "Today, 1:25" };
            ListItemStatus Item6 = new ListItemStatus() { Name1 = "Sunny ", Pic = "Sunny.png", Time1 = "Yesterday, 23:12" };
            ListItemStatus Item7 = new ListItemStatus() { Name1 = "Spencer", Pic = "Spencer.png", Time1 = "Yestrday, 18:50" };
            Items.Add(Item);
            Items.Add(Item1);
            Items.Add(Item2);
            Items.Add(Item3);
            Items.Add(Item4);
            Items.Add(Item5);
            Items.Add(Item6);
            Items.Add(Item7);
            Status.ItemsSource = Items;
        }

        


    }
    
}