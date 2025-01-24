// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bellon.API.Liquidacion.DataBase.Models;

[Table("Usuarios", Schema = "ConsumoInterno")]
public partial class Usuarios
{
    [Key]
    public int id_usuario { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string nombre_usuario { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string correo { get; set; }

    [Required]
    [StringLength(100)]
    public string codigo_sucursal { get; set; }

    [Required]
    [StringLength(100)]
    public string id_sucursal { get; set; }

    [Required]
    [StringLength(100)]
    public string codigo_departamento { get; set; }

    [Required]
    [StringLength(100)]
    public string id_departamento { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal limite { get; set; }

    public int posicion_id { get; set; }

    public bool estado { get; set; }

    [ForeignKey("posicion_id")]
    [InverseProperty("Usuarios")]
    public virtual Posiciones posicion { get; set; }
}