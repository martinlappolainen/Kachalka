using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReliefPage : ContentPage
    {
        Button bt1;
        public List<Relief1> Relief { get; set; }
        public ReliefPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();

            stackLayout.BackgroundColor = Color.Black;
            Relief = new List<Relief1>
            {
                new Relief1 {Title="Жим штанги лежа",Title1="\nКоличество повторений: 8-12 \nКоличество подходов: 3-4"},
                new Relief1 {Title="Жим гантелей лежа",Title1="\nНеделя 1: 3*10–12\n Неделя 2: 4*8–10 "},
                new Relief1 {Title="Сведение рук в тренажере",Title1="\nКоличество повторений: 15-20  \nКоличество подходов: 3"},
                new Relief1 {Title="Подъем штанги на бицепс",Title1="\nКоличество повторений: 8-12\nКоличество подходов: 3-4"},
                new Relief1 {Title="Подъем гантелей на бицепс сидя", Title1="\nКоличество повторений: 15-20\n Количество подходов: 3" },
                new Relief1 {Title="Легкий бег", Title1="\nПродолжительность: 20 минут\n Интенсивность: Легкая" }
               


            };
            bt1 = new Button { Text = "Назад", BackgroundColor = Color.Blue, BorderWidth = 2, BorderColor = Color.White, TextColor = Color.White, CornerRadius = 60 };
            bt1.Clicked += Bt1_Clicked;


            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Relief,
               // Определяем формат отображения данных
               ItemTemplate = new DataTemplate(() =>
               {
                   ImageCell imageCell = new ImageCell { TextColor = Color.White, DetailColor = Color.White };
                   imageCell.SetBinding(ImageCell.TextProperty, "Title");
                   
                   return imageCell;
               })
           };
            listView.ItemTapped += ListView_ItemTapped;
            stackLayout.Children.Add(bt1);
            stackLayout.Children.Add(listView);

            this.Content = stackLayout;

        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Relief1 selectedPit = e.Item as Relief1;
            if (selectedPit != null)
                await DisplayAlert("Как делать", $"{selectedPit.Title} - {selectedPit.Title1}", "OK");
        }

        private async void Bt1_Clicked(object sender, EventArgs e)
        {
            
           await Navigation.PopAsync();
        }

        public class Relief1
            {
            public string Title { get; set; }
            public string Title1 { get; set; }
            }
    }
}