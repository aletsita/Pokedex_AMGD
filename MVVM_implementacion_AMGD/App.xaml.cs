﻿using MVVM_implementacion_AMGD.Vistas;
using MVVM_implementacion_AMGD.Vistas.Pokemon;
using System;
using System.ComponentModel.Design;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_AMGD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Listapokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
