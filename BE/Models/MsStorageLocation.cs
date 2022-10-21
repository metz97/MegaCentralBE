using System;
using System.Collections.Generic;

namespace BE.Models
{
    public partial class MsStorageLocation
    {
        //public MsStorageLocation()
        //{
        //    TrBpkbs = new HashSet<TrBpkb>();
        //}

        public string LocationId { get; set; } = null!;
        public string LocationName { get; set; } = null!;

        //public virtual ICollection<TrBpkb> TrBpkbs { get; set; }
    }
}
