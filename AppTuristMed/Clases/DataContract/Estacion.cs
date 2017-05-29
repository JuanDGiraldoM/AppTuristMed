using System.Runtime.Serialization;

namespace AppTuristMed.Clases
{
    [DataContract]
    class Estacion
    {        
        [DataMember(Name = "municipio")]
        public string Municipio { get; set; }
        [DataMember(Name = "nombrecomercial")]
        public string NombreComercial { get; set; }
        [DataMember(Name = "bandera")]
        public string Bandera { get; set; }
        [DataMember(Name = "direccion")]
        public string Direccion { get; set; }
        [DataMember(Name = "producto")]
        public string Producto { get; set; }
        [DataMember(Name = "precio")]
        public string Precio { get; set; }
        [DataMember(Name = "estado")]
        public string Estado { get; set; }
    }
}
