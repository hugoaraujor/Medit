using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataEntities
{


    public  class PacienteDTO
    {
        public IEnumerable<DependientesDTO> ListaDependientes { get; set; }
        public IEnumerable<DocumentosDTO> ListaDeDocumentos { get; set; }
        public enum Sexo { Masculino = 1, Femenino = 2 };
        public enum EdoCivil { Soltero = 0, Casado = 1, Divorciado = 2, Viudo = 3, Otro = 4 };
        public long PACIENTEID { get; set; }

        
         public string IDENTIFICACION { get; set; }
            public string NOMBRES { get; set; }
            public string APELLIDOS { get; set; }
            public System.DateTime FECHANAC { get; set; }
            public int TIPO { get; set; }
            public string DIRECCION { get; set; }
            public Nullable<int> EMPRESA { get; set; }
            public Nullable<int> ASEGURADORA { get; set; }
           
        public Nullable<int> EDOCIVIL { get; set; }
            public string NOMBRECONYUGUE { get; set; }
            public string TELEFONO { get; set; }
            public string TELEFONO2 { get; set; }
            public string MOVIL { get; set; }
            public Nullable<int> CARGO { get; set; }
            public string EQUIPO { get; set; }
            public string ARCHIVOCEDULA { get; set; }
            public int SEXO { get; set; }
            public int EDAD { get; set; }
            public byte[] CREATED { get; set; }
            public Nullable<System.DateTime> ULTIMAVISITA { get; set; }
            public int CIUDAD { get; set; }
            public int ESTADO { get; set; }
            public string NACIONALIDAD { get; set; }
            public string OBSERVACIONES { get; set; }
            public string FICHALABORAL { get; set; }
           public string SECTOR { get; set; }
        public Nullable<int> ASEGURADORA2 { get; set; }
    }
    public class PacienteCatalogView
    {
        public long PACIENTEID { get; set; }
        [DisplayName("Cedula")]
        public string IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
                public string TELEFONO { get; set; }
        [DisplayName("Telefono Adic.")]
        public string TELEFONO2 { get; set; }
        [DisplayName("Celular")]
        public string MOVIL { get; set; }
        public string OBSERVACIONES { get; set; }
        public string FICHALABORAL { get; set; }
        [DisplayName("Sector")]
        public string SECTOR { get; set; }
    }
}
