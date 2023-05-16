using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WsApiexamen.Models
{
    [MetadataType(typeof(tblExamen.Metada))]
    public partial class tblExamen
    {
        sealed class Metada
        {
            [Required]
            public string Nombre;
        }
    }
}