using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pract62_Kovyazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfProperties : ContentPage
    {
        int rad = 0;
        public ListOfProperties()
        {
            InitializeComponent();
        }

        private void rad2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(rad2.IsChecked)
            {
                rad = 2;
                rad1.IsChecked = false;
                rad3.IsChecked = false;
                rad4.IsChecked = false;
            }
        }

        private void rad1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rad1.IsChecked)
            {
                rad = 1;
                rad2.IsChecked = false;
                rad3.IsChecked = false;
                rad4.IsChecked = false;
            }
        }

        private void rad3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rad3.IsChecked)
            {
                rad = 3;
                rad1.IsChecked = false;
                rad2.IsChecked = false;
                rad4.IsChecked = false;
            }
        }

        private void rad4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rad4.IsChecked)
            {
                rad = 4;
                rad1.IsChecked = false;
                rad3.IsChecked = false;
                rad2.IsChecked = false;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(rad1.IsChecked == false && rad2.IsChecked == false && rad3.IsChecked== false && rad4.IsChecked == false )
            {
                DisplayAlert("Ошибка", "Квартира не выбрана", "ОК");
            }
            else
            {
                await Navigation.PushModalAsync(new PropertyDetails(rad));
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (rad1.IsChecked == false && rad2.IsChecked == false && rad3.IsChecked == false && rad4.IsChecked == false)
            {
                DisplayAlert("Ошибка", "Квартира не выбрана", "Ок");
            }
            else
            {
                if (rad == 1)
                {
                    string[] razdel = lkv1.Text.Split(',');
                    int lkv = int.Parse(razdel[1].ToString());


                    await Navigation.PushModalAsync(new Calculation(lkv,"kv1.jpg",rad));
                }
                else if(rad == 2)
                {
                    string[] razdel = lkv2.Text.Split(',');
                    int lkv = int.Parse(razdel[1].ToString());

                    await Navigation.PushModalAsync(new Calculation(lkv, "kv2.jpg", rad));
                }
                else if(rad == 3)
                {
                    string[] razdel = lkv3.Text.Split(',');
                    int lkv = int.Parse(razdel[1].ToString());

                    await Navigation.PushModalAsync(new Calculation(lkv, "kv3.jpg", rad));
                }
                else if(rad == 4)
                {
                    string[] razdel = lkv4.Text.Split(',');
                    int lkv = int.Parse(razdel[1].ToString());

                    await Navigation.PushModalAsync(new Calculation(lkv, "kv4.jpg", rad));
                }
            }
        }
    }
}