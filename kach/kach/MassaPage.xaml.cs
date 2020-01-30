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
    public partial class MassaPage : ContentPage
    {
        Button bt1;
        public List<Massa1> Massa { get; set; }
        public MassaPage()
        {
            StackLayout stackLayout = new StackLayout();

            stackLayout.BackgroundColor = Color.PeachPuff;
            InitializeComponent();
            Massa = new List<Massa1>
            {
                new Massa1 {Title="Жим штанги на наклонной скамье",Title1="\nНеделя 1: 4(4*2) \nНеделя 2: 3(4*2) \n Неделя 3: 6(4*2) \n Неделя 3: 6(4*2)"},
                new Massa1 {Title="Разводки с гантелями на горизонтали, согнутые ноги на лавке",Title1="\nНеделя 1: 3*10–12\n Неделя 2: 4*8–10 \nНеделя 3: 5*6–8 3  \n Неделя 4: др 8–8–8 "},
                new Massa1 {Title="Отведения с гантелями сидя",Title1="\nНеделя 1: 4*12  \nНеделя 2: 4*10 \n Неделя 3: 6*8 \n Неделя 4: 4*20+част "},
                new Massa1 {Title="Тяга одной гантели к подбородку стоя",Title1="\nНеделя 1: 3*12 (к. р.)\nНеделя 2: 4*10  \n Неделя 3: 6*8 \nНеделя 4: 4 др 6–6–6"},
                new Massa1 {Title="Вертикальная тяга широким хватом за голову", Title1="\nНеделя 1: 4*12\n Неделя 2: 4*10  \nНеделя 3: 6*8  \nНеделя 4: 4*10+част" },
                new Massa1 {Title="Вертикальная тяга с V-образной рукоятью", Title1="\nНеделя 1: 3*12\n Неделя 2: 4*10  \n Неделя 3: 6*8  \nНеделя 4:  Неделя 4: 4 др 6–6–6" },
                new Massa1 {Title="Сгибания с гантелями на бицепс сидя на наклонной скамье", Title1="\nНеделя 1: 3–4*15–12 \n Неделя 2: 4*10–12 \n Неделя 3: 5*10–8  \nНеделя 4: 4*8–6" },
                new Massa1 {Title="Скручивания лежа на полу, ноги подняты", Title1="\nНеделя 1: 3–4*мах повторов\nНеделя 2: 3–4*мах повторов  \nНеделя 3: 3–4*мах повторов  \nНеделя 4: 3–4*мах повторов" }


            };
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Massa,
                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Black, DetailColor = Color.White };
                    imageCell.SetBinding(ImageCell.TextProperty, "Title");
                    Binding companyBinding = new Binding { Path = "Price", StringFormat = "цена:{0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, companyBinding);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
                    return imageCell;
                })
            };
            bt1 = new Button { Text = "Обозночение", BackgroundColor = Color.MediumPurple, BorderWidth = 3, BorderColor = Color.White, TextColor = Color.White, CornerRadius = 70 };
            bt1.Clicked += Bt1_Clicked;

            
            stackLayout.Children.Add(bt1);
            stackLayout.Children.Add(listView);

            this.Content = stackLayout;
            listView.ItemTapped += ListView_ItemTapped;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Massa1 selectedPit = e.Item as Massa1;
            if (selectedPit != null)
                await DisplayAlert("Как делать", $"{selectedPit.Title} - {selectedPit.Title1}", "OK");
        }

        private async void Bt1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Обозначение", "\n*мах повторов — сделай столько повторов, сколько сможешь, до отказа;" +
            "\n част — заверши подход серией из 8–10 коротких повторов в треть амплитуды;" +
            "\n др 10–10–10 — дроп - сет.Сделай с изначальным весом 10 повторов, уменьши вес на 20 процентов и сделай еще 10 повто­ров, вновь уменьши вес на 20 процентов и еще раз сделай 10 повторов;" +
            "\n(к.н.) — количество повторов указано для каждой ноги;" +
            "\n(к.р.) — количество повторов указано для каждой руки.", "OK");
        }

        public class Massa1
        {
            public string Title { get; set; }
            public string Title1 { get; set; }
            
        }
    }
}