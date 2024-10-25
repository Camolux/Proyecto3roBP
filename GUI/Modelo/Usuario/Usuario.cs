using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioDTO
{
    public class Usuario
    {

        public string nombreUsuario { get; set; }
        public string contraUsuario { get; set; }
        public string idTipoUsuario { get; set; }
        public Usuario() { }


        public Usuario(string nombreUsuario, string contraUsuario, string idTipoUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraUsuario = contraUsuario;
            this.idTipoUsuario = idTipoUsuario;
        }
    }



}