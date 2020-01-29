using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kach
{
    [XamlCompilation(XamlCompilationOptions.Compile)] 
    public partial class AddingPage : ContentPage
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        string path = @"//C:/Users/marti/source/repos/kach/trenirovrka.txt";
        Picker picker;
        Entry OpisEntry,uprEntry,podEntry;
        Button bt1;
        Label lbl1;
        public AddingPage()
        {
            string text = File.ReadAllText("temp.txt");
            StackLayout stackLayout = new StackLayout();

            stackLayout.BackgroundColor = Color.PeachPuff;

            lbl1 = new Label() { Text = text, FontSize = 20 };

            picker = new Picker
            {
                Title = "Добавь тренировку"
            };
            picker.Items.Add("Тренировка на массу");
            picker.Items.Add("Тренировка на рельеф");
            picker.Items.Add("Тренировка для тонуса");
            picker.Items.Add("Быстро и Эффективно");
            picker.Items.Add("Долго но качественно");
            picker.Items.Add("Для женщин");

            //picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            OpisEntry = new Entry { Placeholder = "Описание" };
            uprEntry = new Entry { Placeholder = "Название упражнения" };
            podEntry = new Entry { Placeholder = "Подходы" };
            bt1 = new Button { Text = "Сохранить", BackgroundColor = Color.MediumPurple, BorderWidth = 3, BorderColor = Color.White, TextColor = Color.White, CornerRadius = 70 };
            bt1.Clicked += Bt1_Clicked;
            stackLayout.Children.Add(picker);
            stackLayout.Children.Add(OpisEntry);
            stackLayout.Children.Add(uprEntry);
            stackLayout.Children.Add(podEntry);
            stackLayout.Children.Add(bt1);
            stackLayout.Children.Add(lbl1);
           
            this.Content = stackLayout;
        }
        private void Bt1_Clicked(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter(File.Create(fileName)))
            {
                writer.Write(fileName, OpisEntry.Text + uprEntry.Text + podEntry.Text + picker.SelectedIndex, Encoding.UTF8);
                
            }

        }
    }
}