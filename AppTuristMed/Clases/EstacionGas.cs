using SODA.Models;
using System.Runtime.Serialization;

namespace AppTuristMed.Clases
{
    [DataContract]
    class EstacionGas
    {
        [DataMember(Name = "estacion")]
        public string Estacion { get; set; }
        [DataMember(Name = "ciudad")]
        public string Ciudad { get; set; }
        [DataMember(Name = "direccion")]
        public string Direccion { get; set; }
        [DataMember(Name = "ubicacion")]
        public string Ubicacion { get; set; }
        [DataMember(Name = "coordenadas")]
        public LocationColumn Coordenadas { get; set; }
    }
}
