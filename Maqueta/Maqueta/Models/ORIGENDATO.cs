//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maqueta.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ORIGENDATO
    {
        public double ID { get; set; }
        public string DESCRIPCION { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBREARCHIVO { get; set; }
        public string TIPOENTIDAD { get; set; }
        public string ORGANISMO { get; set; }
        public string AUTOR { get; set; }
        public string LINK { get; set; }
        public string API { get; set; }
        public string LINKAPI { get; set; }
        public string APIPUBLICA { get; set; }
        public string TAG { get; set; }
        public Nullable<double> VOLUMETRIA { get; set; }
        public string UNIDADVOLUMETRIA { get; set; }
        public string RUTANAVEGACION { get; set; }
        public string ENLACEDESCARGA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string RUTACARPETA { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FECHACONSULTA { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FECHAINICIODATOS { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FECHAFINALDATOS { get; set; }
    }
}
