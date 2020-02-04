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

            stackLayout.BackgroundColor = Color.Black;
            header = new Label
            {
                Text = "Ваш аккаунт",
                Margin = new Thickness(100, 0, 0, 0),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            image = new Image { Source = "v.png" };

            picker = new Picker
            {
                Title = "Скин",
                TextColor = Color.White,
                TitleColor = Color.White,
                
                
            };
            picker.Items.Add("Весёлый");
            picker.Items.Add("Грустный");
            picker.Items.Add("Пьяный");
            picker.Items.Add("Странный");
            picker.Items.Add("Мужчина");
            picker.Items.Add("Женщина");

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            loginEntry = new Entry { Placeholder = "Login", PlaceholderColor = Color.White, TextColor = Color.White };
            

            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                PlaceholderColor = Color.White,
                TextColor = Color.White
            };

            email = new Entry { Placeholder = "Email", Keyboard = Keyboard.Email ,TextColor= Color.White, PlaceholderColor = Color.White };

            bt1 = new Button { Text = "Сохранить", BackgroundColor = Color.Blue, BorderWidth = 2, BorderColor = Color.White, TextColor = Color.White, CornerRadius = 60 };
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
            
        }
    }
}

    


