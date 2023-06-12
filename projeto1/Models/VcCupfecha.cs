﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Assistente_de_Instalação.Models;

public partial class VcCupfecha
{
    public int IdCupom { get; set; }

    public double Desconto { get; set; }

    public double Taxa { get; set; }

    public double Total { get; set; }

    public double Troco { get; set; }

    public double Cvale { get; set; }

    public double Servico { get; set; }

    public double Repique { get; set; }

    public DateTime Data { get; set; }

    public string Tatual { get; set; }

    public int Posicao { get; set; }

    public int IdMaquina { get; set; }

    public string Cancelado { get; set; }

    public int Turno { get; set; }

    public int IdOperador { get; set; }

    public int? IdCliente { get; set; }

    public int Tipovenda { get; set; }

    public int? IdEntregador { get; set; }

    public int? IdGarcom { get; set; }

    public int? IdVendedor { get; set; }

    public int Pessoas { get; set; }

    public int? IdReserva { get; set; }

    public string Notaf { get; set; }

    public string Enviaint { get; set; }

    public double TotProd { get; set; }

    public double DescProd { get; set; }

    public double TotRes { get; set; }

    public double DescRes { get; set; }

    public double TotAcre { get; set; }

    public double TotDes { get; set; }

    public int Diarias { get; set; }

    public double Respago { get; set; }

    public string Auditor { get; set; }

    public string Cpf { get; set; }

    public int Coo { get; set; }

    public string HoraEntrega { get; set; }

    public string Tempo { get; set; }

    public string HoraPedido { get; set; }

    public string TempoPedido { get; set; }

    public string NomeCliente { get; set; }

    public string Atendido { get; set; }

    public int? Ccf { get; set; }

    public string Dtemite { get; set; }

    public string Ifnome { get; set; }

    public int Coocanc { get; set; }

    public double Entradaserv { get; set; }

    public double Entrada { get; set; }

    public int TotComandas { get; set; }

    public double Consumacao { get; set; }

    public double Consumacaoserv { get; set; }

    public double Prodserv { get; set; }

    public string ChaveDeAcesso { get; set; }

    public string ProtocoloAutorizacao { get; set; }

    public string Liberado { get; set; }

    public int? NumNfce { get; set; }

    public string Inutilizado { get; set; }

    public int? Seq { get; set; }

    public int? LocalCanc { get; set; }

    public string Xmlsat { get; set; }

    public string Xmlnfce { get; set; }

    public string XmlCancSat { get; set; }

    public string XmlCancNfce { get; set; }

    public string ChaveCancSat { get; set; }

    public string ChaveCancNfce { get; set; }

    public string AltRep { get; set; }

    public string CancSist { get; set; }

    public int NumNfcecanc { get; set; }

    public string Bonificado { get; set; }

    public DateTime? DtEnvioCont { get; set; }

    public int? IdClienteCn { get; set; }

    public string TipoIntegracao { get; set; }

    public string MotivoCanc { get; set; }

    public string CodIntegracao { get; set; }

    public bool PosIdent { get; set; }

    public int? IdPedidoIntegracao { get; set; }

    public int? EviRef { get; set; }

    public string EviSent { get; set; }

    public virtual VcMaquinas IdMaquinaNavigation { get; set; }
}