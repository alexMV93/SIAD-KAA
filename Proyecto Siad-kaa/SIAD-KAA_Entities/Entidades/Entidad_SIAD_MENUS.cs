using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAD_KAA_Entities.Entidades
{
    public class Entidad_SIAD_MENUS
    {
        public short PK_MENU  {get; set;}
        public short PK_PORCION { get; set; }
        public short PK_RESTAURANTE { get; set; }
        public short PK_TIPO_MENU { get; set; }
        public string TIM_CODIGO { get; set; }
        public string MEN_CODIGO { get; set; }
        public string MEN_NOMBRE { get; set; }
        public byte[] MEN_IMAGEN { get; set; }
        public decimal MEN_PRECIO { get; set; }
        public decimal MEN_PRECIO_IVI { get; set; }
        public string MEN_PRECIO_IVI_STRING { get; set; }
        public decimal MEN_DESCUENTO { get; set; }
        public string MEN_ESTADO { get; set; }
        public string MEN_USUARIO { get; set; }
    }
}
