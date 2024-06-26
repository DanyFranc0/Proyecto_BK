﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BK.Entities
{
    public partial class tbFactura
    {
        public tbFactura()
        {
            tbFacturaDetalle = new HashSet<tbFacturaDetalle>();
        }

        public int Fact_Id { get; set; }
        public int? Sucu_Id { get; set; }
        public int? Empl_Id { get; set; }
        public DateTime? Fact_Fecha { get; set; }
        public decimal? Fact_Total { get; set; }
        public int? Fact_Usua_Creacion { get; set; }
        public DateTime? Fact_Fecha_Creacion { get; set; }
        public int? Fact_Usua_Modifica { get; set; }
        public DateTime? Fact_Fecha_Modifica { get; set; }
        public bool? Fact_Estado { get; set; }

        public virtual tbEmpleados Empl { get; set; }
        public virtual tbUsuarios Fact_Usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios Fact_Usua_ModificaNavigation { get; set; }
        public virtual tbSucursales Sucu { get; set; }
        public virtual ICollection<tbFacturaDetalle> tbFacturaDetalle { get; set; }
    }
}