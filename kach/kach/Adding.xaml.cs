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

        string path = @"/storage/emulated/0/Android/data/com.companyname.kach/files/trenirovka.txt";
        Picker picker;
        Entry OpisEntry, uprEntry, podEntry;
        Button bt1;
        Label lbl1;
        public AddingPage()
        {

            StackLayout stackLayout = new StackLayout();

            stackLayout.BackgroundColor = Color.PeachPuff;
            string text = File.ReadAllText(path);
            lbl1 = new Label() { Text = text};
            
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
            {
                using (var writer = new StreamWriter(File.Create(path)))
                {
                    writer.Write(OpisEntry.Text + uprEntry.Text + podEntry.Text + picker.SelectedIndex, Encoding.UTF8);
                }

            }


        }
    }
}