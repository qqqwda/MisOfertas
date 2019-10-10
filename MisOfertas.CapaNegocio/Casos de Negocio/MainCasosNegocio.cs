using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    class MainCasosNegocio
    {
        public MainCasosNegocio()
        {

        }

        public NCategoria Categoria { get; set; }
        public NEmpresa Empresa { get; set; }
        public NLocal Local { get; set; }
        public NOferta Oferta { get; set; }
        public NOpinionOferta OpinionOferta { get; set; }
        public NProducto Producto { get; set; }
        public NUsuario Usuario { get; set; }
    }
}
