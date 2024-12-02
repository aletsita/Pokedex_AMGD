using MVVM_implementacion_AMGD.Modelo;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_AMGD.VistaModelo.VMpokemon
{
    public class VMdetallespokemon : BaseViewModel
    {
        #region VARIABLES  
        string _Texto;
        public Mpokemon parametrosRecibe { get; set; }
        string _objcolorfondo;
        string _objcolorpoder;
        string _objnombre;
        string _objnro;
        string _objpoder;
        string _objicono;

        // Agrega las propiedades de color
        private Color _colorpoder;
        public Color Colorpoder
        {
            get { return _colorpoder; }
            set { SetValue(ref _colorpoder, value); }
        }

        private Color _colorfondo;
        public Color Colorfondo
        {
            get { return _colorfondo; }
            set { SetValue(ref _colorfondo, value); }
        }
        #endregion

        #region CONSTRUCTOR

        public VMdetallespokemon(INavigation navigation, Mpokemon parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
            _objcolorfondo = parametrosRecibe.Colorfondo;
            _objcolorpoder = parametrosRecibe.Colorpoder;
            _objnombre = parametrosRecibe.Nombre;
            _objnro = parametrosRecibe.Nroorden;
            _objpoder = parametrosRecibe.Poder;
            _objicono = parametrosRecibe.Icono;
        }
        #endregion

        #region OBJETOS
        public string ColorFondo
        {
            get { return _objcolorfondo; }
            set
            {
                SetValue(ref _objcolorfondo, value);
                OnPropertyChanged(nameof(ColorFondo));
            }

        }

        public string ColorPoder
        {
            get { return _objcolorpoder; }
            set
            {
                SetValue(ref _objcolorpoder, value);
                OnPropertyChanged(nameof(ColorPoder));
            }
        }

        public string Nombre
        {
            get { return _objnombre; }
            set { SetValue(ref _objnombre, value); }
        }

        public string Numero
        {
            get { return _objnro; }
            set { SetValue(ref _objnro, value); }
        }

        public string Poder
        {
            get { return _objpoder; }
            set { SetValue(ref _objpoder, value); }
        }

        public string Icono
        {
            get { return _objicono; }
            set { SetValue(ref _objicono, value); }
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {
            // Lógica del proceso simple
        }
        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
