using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Entities.Entidades;

namespace SIAD_KAA_BussinessLogic.Pedidos
{
    public class blPedido
    {
        #region Variables
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();

        #endregion

        public int logicRegistrarPedido(SIAD_PEDIDOS varPedido)
        {
            int pedido = 0;
            try
            {
                pedido = Convert.ToInt32(varDataContext.SP_REGISTRAR_PEDIDO(varPedido.PK_MESA,
                                                 varPedido.PK_RESTAURANTE,
                                                 varPedido.PED_TOTAL,
                                                 varPedido.PED_ESTADO,
                                                 varPedido.PED_CREADO_POR));
            }
            catch { }
            return pedido;
        }
    }
}
