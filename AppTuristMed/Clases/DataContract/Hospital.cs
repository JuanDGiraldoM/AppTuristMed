using SODA.Models;
using System.Runtime.Serialization;
namespace AppTuristMed.Clases
{
    [DataContract]
    public class Hospital
    {
        [DataMember(Name = "nombre_municipio")]
        public string Municipio { get; set; }
        [DataMember(Name = "nombre_sede")]
        public string NombreSede { get; set; }
        [DataMember(Name = "direcci_n")]
        public string Direccion { get; set; }
        [DataMember(Name = "n_mero_tel_fono")]
        public string Telefono { get; set; }
        [DataMember(Name = "direcci_n_correo_electr_nico")]
        public string Email { get; set; }
        [DataMember(Name = "punto")]
        public LocationColumn Ubicacion { get; set; }
    }

}
