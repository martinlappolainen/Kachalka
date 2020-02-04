using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kach
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            
            InitializeComponent();

            Grid grid = new Grid();
            grid.BackgroundColor = Color.Black;
            grid.RowDefinitions.Add(new RowDefinition {});
            grid.RowDefinitions.Add(new RowDefinition { });
            grid.RowDefinitions.Add(new RowDefinition { });
            grid.RowDefinitions.Add(new RowDefinition { });
            grid.RowDefinitions.Add(new RowDefinition { });
            grid.ColumnDefinitions.Add(new ColumnDefinition { });
            grid.ColumnDefinitions.Add(new ColumnDefinition { });

            //Grid.SetRowSpan(Lable, 2);
            grid.Children.Add(Lable, 0, 0);
            
            grid.Children.Add(AkkauntPage, 0, 1);
            grid.Children.Add(ReliefPage, 1, 1);
            grid.Children.Add(MassaPage, 1, 2);
            grid.Children.Add(PitaniePage, 0, 2);
            grid.Children.Add(Adding, 0, 3);
            grid.Children.Add(TraningPage, 1, 3);
            

            Content = grid;
        }

        


        private async void AkkauntPage_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new AkkauntPage());
        }

        private async void ReliefPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReliefPage());
        }

        private async void MassaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MassaPage());
        }

        private async void PitaniePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PitaniePage());
        }

        private async void AddingPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddingPage());
        }

        private async void Traning_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TraningPage());
        }
    }
}
