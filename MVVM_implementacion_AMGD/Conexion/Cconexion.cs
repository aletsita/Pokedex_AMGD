using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using MVVM_implementacion_AMGD.Conexion;

namespace MVVM_implementacion_AMGD.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://proyecto-mvvm-amgd-default-rtdb.firebaseio.com/");
    }
}
