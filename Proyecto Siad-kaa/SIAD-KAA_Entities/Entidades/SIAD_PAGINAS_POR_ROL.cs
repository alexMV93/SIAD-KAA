using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAD_KAA_Entities.Entidades
{
    public class SIAD_PAGINAS_POR_ROL
    {
        #region Atributos y Propiedades
        private string _PPR_INGRESO;
        public string PPR_INGRESO
        {
            get { return _PPR_INGRESO; }
            set { _PPR_INGRESO = value; }
        }

        private string _PPR_MODIFICACION;
        public string PPR_MODIFICACION
        {
            get { return _PPR_MODIFICACION; }
            set { _PPR_MODIFICACION = value; }
        }

        private string _PPR_ELIMINACION;
        public string PPR_ELIMINACION
        {
            get { return _PPR_ELIMINACION; }
            set { _PPR_ELIMINACION = value; }
        }

        private string _PPR_CREACION;
        public string PPR_CREACION
        {
            get { return _PPR_CREACION; }
            set { _PPR_CREACION = value; }
        }

        private int _PK_PAGINA;
        public int PK_PAGINA
        {
            get { return _PK_PAGINA; }
            set { _PK_PAGINA = value; }
        }

        private string _PAG_RUTA;
        public string PAG_RUTA
        {
            get { return _PAG_RUTA; }
            set { _PAG_RUTA = value; }
        }

        private string _PAG_TIPO;
        public string PAG_TIPO
        {
            get { return _PAG_TIPO; }
            set { _PAG_TIPO = value; }
        }

        private string _PAG_ICONO;
        public string PAG_ICONO
        {
            get { return _PAG_ICONO; }
            set { _PAG_ICONO = value; }
        }
        #endregion

        #region Constructores
        public SIAD_PAGINAS_POR_ROL() { }
        public SIAD_PAGINAS_POR_ROL(string varPPR_INGRESO, string varPPR_MODIFICACION, string varPPR_ELIMINACION, string varPPR_CREACION, int varPK_PAGINA, string varPAG_RUTA, string varPAG_TIPO, string varPAG_ICONO)
        {
            _PPR_INGRESO = varPPR_INGRESO;
            _PPR_MODIFICACION = varPPR_MODIFICACION;
            _PPR_ELIMINACION = varPPR_ELIMINACION;
            PPR_CREACION = varPPR_CREACION;
            _PK_PAGINA = varPK_PAGINA;
            _PAG_RUTA = varPAG_RUTA;
            PAG_TIPO = varPAG_TIPO;
            _PAG_ICONO = varPAG_ICONO;
        }

        #endregion
    }
}
