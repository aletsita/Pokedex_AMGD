using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_AMGD.Modelo;

namespace MVVM_implementacion_AMGD.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MiUsuario> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion

        #region PROCESOS
        public void MostrarUsuarios()
        {
            listausuarios = new List<MiUsuario>
            {
                new MiUsuario
                {
                    Nombre = "Alexa",
                    Imagen = "https://i.ibb.co/pbRWPSL/minions-stuart-despicable-me-by-gruydruamarillo-dfz7bup-pre.png"
                },
                new MiUsuario
                {
                    Nombre = "Emiliano",
                    Imagen = "https://i.ibb.co/7gFqRhY/ddaa0e0b9e72b14dbc07a7de53826731.png"
                },
                new MiUsuario
                {
                    Nombre = "Nicol",
                    Imagen = "https://i.ibb.co/1dhZByk/2896c228205af6c54c643c82fce86c16.png"
                }
            };
        }
        public async Task Alerta(MiUsuario parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        #endregion

        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand AlertaCommand => new Command<MiUsuario>(async (p) => await Alerta(p));
        #endregion
    }

}
