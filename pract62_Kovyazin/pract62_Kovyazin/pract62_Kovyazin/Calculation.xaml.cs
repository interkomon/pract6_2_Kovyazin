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
    public partial class Calculation : ContentPage
    {
        int r;
        int cs;
        double ssum;
        public Calculation(int lkv,string kv,int rad)
        {
            r = rad;
            InitializeComponent();
            picker.SelectedIndex = 0;
            
            cs = lkv;
            if(rad == 1)
            {
                price.Text =  $"Цена квартиры: {cs.ToString()}";
            }
            else if(rad == 2)
            {
                price.Text = $"Цена квартиры: {cs.ToString()}";
            }
            else if(rad == 3)
            {
                price.Text = $"Цена квартиры: {cs.ToString()}";
            }
            else if(rad == 4)
            {
                price.Text = $"Цена квартиры: {cs.ToString()}";
            }
        }
        
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PropertyDetails(r));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListOfProperties());
        }

        private void raschet_Clicked(object sender, EventArgs e)
        {
            try
            {
                int opl = 0;
                ssum = 0;
                ssum = cs;
                
                if (picker.SelectedIndex == -1 || srok.Text == "")
                {
                    DisplayAlert("Ошибка","Выберите вид расчета или заполните все поля", "ОК");
                }
                else if (int.Parse(srok.Text) < 1)
                {
                    DisplayAlert("Ошибка", "срок не может быть меньше 1", "ОК");
                }
                else if (int.Parse(srok.Text) > 20)
                {
                    sum.Text = "0";
                }
                else if (picker.SelectedIndex == 0)
                {
                    ssum *= 0.9;
                }
                else if (picker.SelectedIndex == 1)
                {
                    ssum *= 1.1;
                }
                if (int.Parse(srok.Text) > 0 && int.Parse(srok.Text) < 5)
                {
                    while (int.Parse(srok.Text) != opl)
                    {
                        ssum *= 1.05;
                        opl++;
                    }
                    opl = 0;
                }
                else if (int.Parse(srok.Text) > 4 && int.Parse(srok.Text) < 11)
                {
                    while (int.Parse(srok.Text) != opl)
                    {
                        ssum *= 1.1;
                        opl++;
                    }
                    opl = 0;
                }
                else if (int.Parse(srok.Text) > 10 && int.Parse(srok.Text) < 21)
                {
                    while (int.Parse(srok.Text) != opl)
                    {
                        ssum *= 1.15;
                        opl++;
                    }
                    opl = 0;
                }
                ssum = Math.Round(ssum, 0);
                sum.Text = $"Сумма равна: {ssum} руб.";
            }catch
            {
                DisplayAlert("Ошибка","Ошибка при вводе данных или выборе", "ОК");
            }
            


        }
            
        }
    }
