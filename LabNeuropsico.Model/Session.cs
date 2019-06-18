using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNeuropsico.Model.Entidades;
using LabNeuropsico.Model;

namespace LabNeuropsico.Model.Session
{
    public static class Session
    {
        private static Usuario usuario;

        public static Usuario Usuario { get => usuario; set => usuario = value; }

        static Session()
        {
            ClearSession();
        }


        public static void ClearSession()
        {
            Usuario = null;
        }

        public static void SetSession(Usuario usuario)
        {
            Usuario = usuario;
        }
    }
}
