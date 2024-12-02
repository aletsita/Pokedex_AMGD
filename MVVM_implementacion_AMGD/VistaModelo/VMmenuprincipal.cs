using MVVM_implementacion_AMGD.Modelo;
using MVVM_implementacion_AMGD.Vistas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_AMGD.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MmenuPrincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion

        #region PROCESOS
        public void MostrarPaginas()
        {
            listapaginas = new List<MmenuPrincipal>
            {
                new MmenuPrincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegación",
                    Icono = "https://i.postimg.cc/vTTCbtxT/navegacion.gif"
                },
                new MmenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://i.postimg.cc/pLzYh5Dd/base-de-datos.gif"
                },
                new MmenuPrincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.postimg.cc/DZrF7vWS/pikachu.png"
                }
            };
        }
        public async Task Navegar(MmenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;

            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }

            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }

            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple());
        public ICommand NavegarCommand => new Command<MmenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
