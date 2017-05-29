using SODA.Models;
using System.Runtime.Serialization;

namespace AppTuristMed.Clases
{
    [DataContract]
    class WiFi
    {
        [DataMember(Name = "nombre_comuna")]
        public string Comuna { get; set; }
        [DataMember(Name = "barrio")]
        public string Barrio { get; set; }
        [DataMember(Name = "nombre_del_sitio")]
        public string NombreSitio { get; set; }
        [DataMember(Name = "direcci_n")]
        public string Direccion { get; set; }
        [DataMember(Name = "latitud_y")]
        public LocationColumn Ubicacion { get; set; }
    }
}
