using DocumentFormat.OpenXml.Drawing;
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
    public partial class PitaniePage : ContentPage
    {

        public List<Sport> Pitanie { get; set; }
        public PitaniePage()
        {
            InitializeComponent();
            Pitanie = new List<Sport>
            {
                new Sport {Title="ICONFIT BCAA 2:1:1, 400g",Title1="\nВысококачественный аминокислотный комплекс с разветвленной цепью с более высоким " +
                "содержанием аминокислот, чем у большинства конкурирующих продуктов.", Company="IconFit",Price="16€", ImagePath="bcaa.jpg" },
                new Sport {Title="Protein.Buzz Whey Isolate 2000g",Title1="\nВ 1 порции:\n -20. 8 г белка (обогащенный ВСАА и L-глютамином)" +
                "\n- низкое содержание жира и только 1 г углеводов \n- без сахара \n- без аспартама", Company="Protein.Buzz", Price="47€", ImagePath="prbuzz.jpg" },
                new Sport {Title="Optimum Nutrition 100% Gold Standard Casein 1,8kg",Title1="24 грамма высококачественного, укрепленного энзимами " +
                "антикатаболический мицеллярный казеин 10 грамм BCAA, глютамина в одной мерной ложке Улучшенный AMINOGEN", Company="Optimum Nutrition", Price="62€", ImagePath="gs.jpg" },
                new Sport {Title="SAN 100% Pure Titanium Whey, 2.27kg",Title1="100% Pure Titanium Whey был создан для того, чтобы максимально" +
                " противодействовать послетренировочному катаболизму " +
                "(разрушению мышц), а его анаболическое действие длится ДО 4 ЧАСОВ.", Company="SAN", Price="49€", ImagePath="san.jpg" },
                new Sport {Title="Mutant Mass, 2270g", Title1="Mutant Mass — супермощный гейнер для набора мышечной массы, " +
                "обеспечивающий максимальный рост мышечной массы и полноценное восстановление после тренировок в течение всего дня..."
                ,Company="Mutant", Price="23€", ImagePath="mut.jpg" }
            };
            Label header = new Label
            {
                Text = "Лучшее За свою цену",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.White
            };
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Pitanie,
                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell {TextColor = Color.White, DetailColor = Color.White };
                    imageCell.SetBinding(ImageCell.TextProperty, "Title");
                    Binding companyBinding = new Binding { Path = "Price", StringFormat = "цена:{0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, companyBinding);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
                    return imageCell;
                })
            };
            listView.ItemTapped += OnItemTapped;
            this.Content = new StackLayout { Children = { header, listView } };
            this.BackgroundColor = Color.Black;
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Sport selectedPit = e.Item as Sport;
            if (selectedPit != null)
                await DisplayAlert("Выбранные Добавки", $"{selectedPit.Company} - {selectedPit.Title1}", "OK");
        }
    }
    

    public class Sport
    {
        public string Title { get; set; }
        public string Title1 { get; set; }
        public string ImagePath { get; set; }
        public string Company { get; set; }
        public string Price { get; set; }
    }
}