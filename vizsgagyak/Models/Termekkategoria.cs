using System;
using System.Collections.Generic;

namespace vizsgagyak.Models;

public partial class Termekkategoria
{
    public int KatId { get; set; }

    public string KatNev { get; set; } = null!;

    public int? SzuloKat { get; set; }

    public virtual ICollection<Termekkategoria> InverseSzuloKatNavigation { get; set; } = new List<Termekkategoria>();

    public virtual Termekkategoria? SzuloKatNavigation { get; set; }

    public virtual ICollection<Termek> Termek { get; set; } = new List<Termek>();
}
