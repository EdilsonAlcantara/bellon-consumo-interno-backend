﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bellon.API.Liquidacion.DataBase.Models;

[Table("HistCabeceraLiquidaciones", Schema = "Liquidacion")]
public partial class HistCabeceraLiquidaciones
{
    [Key]
    public int id_hist_cabecera_liquidacion { get; set; }

    public int no_serie_id { get; set; }

    [StringLength(20)]
    public string no_documento { get; set; } = null!;

    public DateOnly fecha_documento { get; set; }

    public DateOnly fecha_registro { get; set; }

    [StringLength(50)]
    public string nombre_proveedor { get; set; } = null!;

    [StringLength(30)]
    public string no_dua { get; set; } = null!;

    public DateOnly fecha_dua { get; set; }

    [StringLength(100)]
    public string dga_liquidacion { get; set; } = null!;

    public int agente_id { get; set; }

    [StringLength(100)]
    public string detalle_mercancia { get; set; } = null!;

    [StringLength(20)]
    public string no_conocimiento_embarque { get; set; } = null!;

    [Column(TypeName = "decimal(38, 20)")]
    public decimal tasa_dolar { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal total_gasto_manejo { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_seguro { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_flete { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_otros_gastos { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal tasa_aduana { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_multa { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_articulo_52 { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal monto_impuesto { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal total_cif_general { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal total_gravamen_general { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal total_selectivo_general { get; set; }

    [Column(TypeName = "decimal(38, 20)")]
    public decimal total_itbis_general { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fecha_creado { get; set; }

    [StringLength(100)]
    public string creado_por { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? fecha_modificado { get; set; }

    [StringLength(100)]
    public string? modificado_por { get; set; }

    [InverseProperty("hist_cabecera_liquidacion")]
    public virtual ICollection<HistCargosAdicionales> HistCargosAdicionales { get; set; } = new List<HistCargosAdicionales>();

    [InverseProperty("hist_cabecera_liquidacion")]
    public virtual ICollection<HistLineaLiquidaciones> HistLineaLiquidaciones { get; set; } = new List<HistLineaLiquidaciones>();

    [ForeignKey("agente_id")]
    [InverseProperty("HistCabeceraLiquidaciones")]
    public virtual Agentes agente { get; set; } = null!;

    [ForeignKey("no_serie_id")]
    [InverseProperty("HistCabeceraLiquidaciones")]
    public virtual NoSeries no_serie { get; set; } = null!;
}