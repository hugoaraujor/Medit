using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class IngresosDTO
    {
        public enum TipoIngresoenum
        {

            [Description("CONSULTA MEDICINA GENERAL")]
            Consulta = 0,
            [Description("CONSULTA ESPECIALISTA")]
            ConsultaEsp = 1,
            [Description("LABORATORIO")]
            Laboratorio = 2,
            [Description("ECOGRAFIA")]
            ecografia = 3,
            [Description("ELECTROCARDIOGRAMA")]
            electrocardiograma = 4,
            [Description("RADIOGRAFIA RX")]
            radiografia = 5,
            [Description("AMBULATORIO DE EMERGENCIA MAS TRATAMIENTO")]
            ambulatorio = 6,
            [Description("HOSPITALIZACION")]
            hospitalizacion = 7,
            [Description("QUIROFANO O SALA DE PARTO")]
            Quirofano = 8
        };
  ///      string friendlyDescription = Enum<ApplianceType>.Description(9);

        public static class Enum<T>
        {
            public static string Description(T value)
            {
                DescriptionAttribute[] da = (DescriptionAttribute[])(typeof(T).GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false));
                return da.Length > 0 ? da[0].Description : value.ToString();
            }
        }


        public long admisionid { get; set; }
        public System.DateTime fechaingreso { get; set; }
        public Nullable<System.DateTime> fechasalida { get; set; }
        public Nullable<int> procesada { get; set; }
        public int motivo { get; set; }
        public string observaciones { get; set; }
        public int tipodeingreso { get; set; }
        public string ticket { get; set; }
        public string clave { get; set; }
        public byte[] created { get; set; }
        public long trabajadorid { get; set; }
        public string cedulatrabajador { get; set; }
        public long dependienteid { get; set; }
        public string nombrepaciente { get; set; }
        public string ceduladebeneficiario { get; set; }
        public bool? esbeneficiario { get; set; }
        public string cedulapaciente { get; set; }
        public int usuarioid { get; set; }
        public long? refieremedico { get; set; }
        public Nullable<int> empresaid { get; set; }
        public Nullable<int> aseguradoraid { get; set; }
    }
}
