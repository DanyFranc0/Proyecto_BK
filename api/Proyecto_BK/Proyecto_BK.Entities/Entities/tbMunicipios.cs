﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BK.Entities
{
    public partial class tbMunicipios
    {
        public tbMunicipios()
        {
            tbClientes = new HashSet<tbClientes>();
            tbEmpleados = new HashSet<tbEmpleados>();
            tbSucursales = new HashSet<tbSucursales>();
        }

        public string Muni_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public string Dept_Codigo { get; set; }
        public int Muni_Usua_Creacion { get; set; }
        public DateTime Muni_Fecha_Creacion { get; set; }
        public int? Muni_Usua_Modifica { get; set; }
        public DateTime? Muni_Fecha_Modifica { get; set; }

        public virtual tbDepartamentos Dept_CodigoNavigation { get; set; }
        public virtual tbUsuarios Muni_Usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios Muni_Usua_ModificaNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientes { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbSucursales> tbSucursales { get; set; }
    }
}