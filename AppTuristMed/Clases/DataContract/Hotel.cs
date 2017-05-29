using System.Runtime.Serialization;

namespace AppTuristMed.Clases
{
    [DataContract]
    class Hotel
    {
        [DataMember(Name = "column0")]
        public string Nombre { get; set; }
        [DataMember(Name = "column1")]
        public string Direccion { get; set; }
        [DataMember(Name = "column2")]
        public string Telefono { get; set; }
        [DataMember(Name = "column3")]
        public string Propietario { get; set; }
    }
}
