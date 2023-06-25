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


    public partial class PropertyDetails : ContentPage
    {
        int r;
        List<Property> properties;
        public PropertyDetails(int rad)
        {
            InitializeComponent();
            r = rad;
            properties = new List<Property>
            {  new Property
            {
                NameVl = "Дмитрий Александрович Шурков",
                Address = "г.Екатеринбург,ул Чернеховская 68, кв.456",
                Characteristic = "Большая просторная квартира, уютная, хорошие хохяева оставили собаку",
                Area = 150,
                RoomNumber = 9,
                Price = 140000000,
                Floor = 18




            },
            new Property
            {
                NameVl = "Кирилл Викторович Максимов",
                Address = "г.Екатеринбург,ул Молотова 78, кв.76",
                Characteristic = "Хорошая маленькая квартира для семьи, рядом школа",
                Area = 35,
                RoomNumber = 2,
                Price = 5000000,
                Floor = 5




            },
            new Property
            {
                NameVl = "Булат Каадырович Деспижек",
                Address = "г.Екатеринбург, ул Свободы 79, кв.785",
                Characteristic = "Уютная квартира",
                Area = 50,
                RoomNumber = 4,
                Price = 7000000,
                Floor = 10




            },
            new Property
            {
                NameVl = "Андрей Михайлович Ковязин",
                Address = "г.Екатеринбург,ул Мира 55, кв.55",
                Characteristic = "Большая симпотичная квартира",
                Area = 100,
                RoomNumber = 5,
                Price = 30000000,
                Floor = 9




            }
            };
            
        
          if(rad == 1)
            {
                kvimg.Source = "kv1.jpg";
                NameV.Text = $"Владелец: {properties[0].NameVl}";
                addres.Text = $"Адрес:  {properties[0].Address}";
                Charecterist.Text = $"{properties[0].Characteristic}";
                areaa.Text = $"{properties[0].Area} кв.м";
                kolvokomnat.Text = $"Кол-во комнат:{properties[0].RoomNumber}";
                chena.Text =  $"Цена: {properties[0].Price}";
                etaj.Text = $"Этаж: {properties[0].Floor}";
               
                

            }
          else if(rad == 2)
            {

                kvimg.Source = "kv2.jpg";
                NameV.Text = $"Владелец: {properties[1].NameVl}";
                addres.Text = $"Адрес:  {properties[1].Address}";
                Charecterist.Text = $"{properties[1].Characteristic}";
                areaa.Text = $"{properties[1].Area} кв.м";
                kolvokomnat.Text = $"Кол-во комнат:{properties[1].RoomNumber}";
                chena.Text = $"Цена: {properties[1].Price}";
                etaj.Text = $"Этаж: {properties[1].Floor}";
            }
          else if(rad == 3)
            {

                kvimg.Source = "kv3.jpg";
                NameV.Text = $"Владелец: {properties[2].NameVl}";
                addres.Text = $"Адрес:  {properties[2].Address}";
                Charecterist.Text = $"{properties[2].Characteristic}";
                areaa.Text = $"{properties[2].Area} кв.м";
                kolvokomnat.Text = $"Кол-во комнат:{properties[2].RoomNumber}";
                chena.Text = $"Цена: {properties[2].Price}";
                etaj.Text = $"Этаж: {properties[2].Floor}";
            }
          else if(rad == 4)
            {

                kvimg.Source = "kv4.jpg";
                NameV.Text = $"Владелец: {properties[3].NameVl}";
                addres.Text = $"Адрес:  {properties[3].Address}";
                Charecterist.Text = $"{properties[3].Characteristic}";
                areaa.Text = $"{properties[3].Area} кв.м";
                kolvokomnat.Text = $"Кол-во комнат:{properties[3].RoomNumber}";
                chena.Text = $"Цена: {properties[3].Price}";
                etaj.Text = $"Этаж: {properties[3].Floor}";
            }




        }

		private async void Button_Clicked(object sender, EventArgs e)
		{

            if(r == 1)
            {
                int price = int.Parse(properties[0].Price.ToString());
                await Navigation.PushModalAsync(new Calculation(price, "kv1.jpg", r));
            }
            else if(r == 2)
            {
                int price = int.Parse(properties[1].Price.ToString());
                await Navigation.PushModalAsync(new Calculation(price, "kv2.jpg", r));
            }
            else if(r == 3)
            {
                int price = int.Parse(properties[2].Price.ToString());
                await Navigation.PushModalAsync(new Calculation(price, "kv3.jpg", r));
            }
            else if(r == 4)
            {
                int price = int.Parse(properties[3].Price.ToString());
                await Navigation.PushModalAsync(new Calculation(price, "kv4.jpg", r));
            }
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}