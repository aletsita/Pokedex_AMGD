using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_implementacion_AMGD.VistaModelo.VMpokemon;
using Sharpnado.MaterialFrame;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_AMGD.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listapokemon : ContentPage
    {
        public Listapokemon()
        {
            InitializeComponent();
            BindingContext = new VMlistapokemon(Navigation);
        }

    }
}