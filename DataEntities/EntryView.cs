using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataEntities
{
    
        public class EntryView
    {
        public string Cedula;
        public string nombreAutorizado;
        public string nombreBeneficiario;
        public string cedulabeneficiario;
        public long idpaciente;
        public long idbeneficiario;
        public DateTime Fecha;
        public DependientesDTO.parentesco parentesco;
        public bool esbeneficiario;
        public int tipoingreso;
        public int? idempresa;
        public int? idaseguradora;
    }

    public class EntryView2
    {

    }
}
