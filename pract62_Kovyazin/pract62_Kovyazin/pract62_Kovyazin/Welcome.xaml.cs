﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace pract62_Kovyazin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void signin_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(pass.Text))
            {
                DisplayAlert("Ошибка", "Заполните все поля", "Окей");
                return;
            }
            else
            {
                
                 Navigation.PushModalAsync(new ListOfProperties());
            }
        }
    }
}