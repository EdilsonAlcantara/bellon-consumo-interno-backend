﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bellon.API.Liquidacion.DataBase.Models;

[Table("NoSeries", Schema = "Liquidacion")]
[Index("codigo", Name = "UQ__NoSeries__40F9A2065B81FB94", IsUnique = true)]
public partial class NoSeries
{
    [Key]
    public int id_no_serie { get; set; }

    [StringLength(10)]
    public string codigo { get; set; } = null!;

    [StringLength(50)]
    public string descripcion { get; set; } = null!;

    [StringLength(20)]
    public string secuencia_inicial { get; set; } = null!;

    [StringLength(20)]
    public string ultima_secuencia_utilizada { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime fecha_ultima_secuencia_utilizada { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fecha_creado { get; set; }

    [StringLength(100)]
    public string creado_por { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? fecha_modificado { get; set; }

    [StringLength(100)]
    public string? modificado_por { get; set; }

    [InverseProperty("no_serie")]
    public virtual ICollection<CabeceraLiquidaciones> CabeceraLiquidaciones { get; set; } = new List<CabeceraLiquidaciones>();

    [InverseProperty("no_serie")]
    public virtual ICollection<CabeceraLlegadas> CabeceraLlegadas { get; set; } = new List<CabeceraLlegadas>();

    [InverseProperty("no_serie")]
    public virtual ICollection<CabeceraTransito> CabeceraTransito { get; set; } = new List<CabeceraTransito>();

    [InverseProperty("no_serie")]
    public virtual ICollection<HistCabeceraLiquidaciones> HistCabeceraLiquidaciones { get; set; } = new List<HistCabeceraLiquidaciones>();

    [InverseProperty("no_serie")]
    public virtual ICollection<HistCabeceraLlegadas> HistCabeceraLlegadas { get; set; } = new List<HistCabeceraLlegadas>();

    [InverseProperty("no_serie")]
    public virtual ICollection<HistCabeceraTransitos> HistCabeceraTransitos { get; set; } = new List<HistCabeceraTransitos>();

    [InverseProperty("no_serie")]
    public virtual ICollection<CabeceraSolicitudes> CabeceraSolicitudes { get; set; } = new List<CabeceraSolicitudes>();
}