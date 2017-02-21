using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SIAD_KAA_Entities.Conexion
{
    public partial class SIAD_KAABaseDatosDataContext
    {
        public SIAD_KAABaseDatosDataContext() :
            base(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        //public SIAD_KAABaseDatosDataContext() :
        //    base(global::SIAD_KAA_Entities.Properties.Settings.Default.SIAD_KAA_SolucionesConnectionString, mappingSource)
        //{
        //    OnCreated();
        //}
    }
}
