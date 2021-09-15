using System;
using System.Collections.Generic;

#nullable disable

namespace _14._9._2021.Model
{
    public partial class Lopsh
    {
        public Lopsh()
        {
            Svs = new HashSet<Sv>();
        }

        public int IdLop { get; set; }
        public string NameLop { get; set; }

        public virtual ICollection<Sv> Svs { get; set; }
    }
}
