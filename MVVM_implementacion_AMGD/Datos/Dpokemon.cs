using MVVM_implementacion_AMGD.Conexion;
using MVVM_implementacion_AMGD.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;
using System.Linq;
using Firebase.Database;


namespace MVVM_implementacion_AMGD.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = parametros.Colorfondo,
                    Colorpoder = parametros.Colorpoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    Nroorden = parametros.Nroorden,
                    Poder = parametros.Poder
                }
                );
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            //var data = (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemon>())
            //    .Where(a=>a.Key!="Modelo")
            //    .Select(item => new Mpokemon
            //    {
            //        Idpokemon = item.Key,
            //        Nombre = item.Object.Nombre,
            //        Colorfondo = item.Object.Colorfondo,
            //        Colorpoder = item.Object.Colorpoder,
            //        Nroorden = item.Object.Nroorden,
            //        Poder = item.Object.Poder,
            //        Icono = item.Object.Icono
            //    }

            //    );


            var data = await Task.Run(() => Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection()
                );
            return data;

        }


    }
}

