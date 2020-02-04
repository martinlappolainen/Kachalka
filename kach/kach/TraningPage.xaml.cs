using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TraningPage : ContentPage
    {
        
        
        Label lbl1,lbl2;
        public TraningPage()
        {
            string path = @"/storage/emulated/0/Android/data/com.companyname.kach/files/trenirovka.txt";
            
            StackLayout stackLayout = new StackLayout();
            
            this.BackgroundColor = Color.Black;
            lbl2 = new Label() { Text = "Мои тренировки" ,TextColor = Color.White, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))};
            string text = File.ReadAllText(path);
            lbl1 = new Label() { TextColor =Color.White,
                Text = text };
            stackLayout.Children.Add(lbl2);
            stackLayout.Children.Add(lbl1);
            
            this.Content = stackLayout;
            
        }

    }
}