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
    public partial class AkkauntPage : ContentPage
    {

        Label header;
        Entry loginEntry, passwordEntry, email;
        Label textLabel;
        Picker picker;
        Image image;
        Button bt1;
        public AkkauntPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();

            stackLayout.BackgroundColor = Color.PeachPuff;
            header = new Label
            {
                Text = "Ваш аккаунт",
                Margin = new Thickness(100, 0, 0, 0),
                TextColor = Color.MidnightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            image = new Image { Source = "v.png" };

            picker = new Picker
            {
                Title = "Скин"
            };
            picker.Items.Add("Весёлый");
            picker.Items.Add("Грустный");
            picker.Items.Add("Пьяный");
            picker.Items.Add("Странный");
            picker.Items.Add("Мужчина");
            picker.Items.Add("Женщина");

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            loginEntry = new Entry { Placeholder = "Login" };
            //loginEntry.TextChanged += LoginEntry_TextChanged;

            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            email = new Entry { Placeholder = "Email", Keyboard = Keyboard.Email };

            bt1 = new Button { Text = "Сохранить", BackgroundColor = Color.MediumPurple, BorderWidth = 3, BorderColor = Color.White, TextColor = Color.White, CornerRadius = 70 };
            bt1.Clicked += Bt1_Clicked;

            textLabel = new Label { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            stackLayout.Children.Add(header);
            stackLayout.Children.Add(image);
            stackLayout.Children.Add(picker);
            stackLayout.Children.Add(loginEntry);
            stackLayout.Children.Add(passwordEntry);
            stackLayout.Children.Add(email);
            stackLayout.Children.Add(bt1);
            stackLayout.Children.Add(textLabel);
            this.Content = stackLayout;
        }


        private async void BackMain_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private void Bt1_Clicked(object sender, EventArgs e)
        {
            //using (var writer = new StreamWriter(File.Create(path)))
            //{
            //    writer.Write(email.Text + passwordEntry.Text + loginEntry.Text + picker.SelectedIndex, Encoding.UTF8);
            //}

        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (picker.SelectedIndex == 0)
            //{
            //    image.Source = "ves.jpg";
            //}
            //if (picker.SelectedIndex == 1)
            //{
            //    image.Source = "grust.jpeg";
            //}
            //if (picker.SelectedIndex == 2)
            //{
            //    image.Source = "pjan.jpg";
            //}
            //if (picker.SelectedIndex == 3)
            //{
            //    image.Source = "loh.jpg";
            //}
            //if (picker.SelectedIndex == 4)
            //{
            //    image.Source = "muz.png";
            //}
            //if (picker.SelectedIndex == 5)
            //{
            //    image.Source = "zen.png";
            //}
        }
    }
}

    


