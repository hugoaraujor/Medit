using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public  class ClinicaDTO
    {
        public ClinicaDTO()
        { }
        public ClinicaDTO( string CLINICA ,string RIF, string Direccion1, string Direccion2, string Direccion3, string Direccion4, string Ciudad,
                                        string Telefonos, string responsable,
                                        string DirectorioImagenes,
                                        string DirectorioExportados,
                                         string Correo, string ArchivoLogo,
                                          string numerodeLicencia,
                                           string CLINICA1)
        {
           
            this.CLINICA1 = CLINICA1;
            this.RIF = RIF;
            this.Direccion1 = Direccion1;
            this.Direccion2 = Direccion2;
            this.Direccion3 = Direccion3;
            this.Direccion4 = Direccion4;
            this.Ciudad = Ciudad;
            this.Telefonos = Telefonos;
            this.responsable = responsable;
            this.DirectorioImagenes = DirectorioImagenes;
            this.DirectorioExportados = DirectorioExportados;
            this.Correo = Correo;
            this.ArchivoLogo = ArchivoLogo;
            this.numerodeLicencia = numerodeLicencia;
            this.IDCLINICA = IDCLINICA;
           
        }

        public int Id { get; set; }
        public string CLINICA1 { get; set; }
        public string RIF { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public string Direccion4 { get; set; }
        public string Ciudad { get; set; }
        public string Telefonos { get; set; }
        public string responsable { get; set; }
        public string DirectorioImagenes { get; set; }
        public string DirectorioExportados { get; set; }
        public string Correo { get; set; }
        public string ArchivoLogo { get; set; }
        public string numerodeLicencia { get; set; }
        public Nullable<System.DateTime> FechadeInstalación { get; set; }
        public int IDCLINICA { get; set; }
    }
}
