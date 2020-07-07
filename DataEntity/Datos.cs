namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datos
    {
        public int id { get; set; }

        public decimal L { get; set; }

        public decimal Lq { get; set; }

        public decimal W { get; set; }

        public decimal Wq { get; set; }

        public decimal P { get; set; }

        public decimal Po { get; set; }

        public decimal Pnk { get; set; }

        public DateTime fecha { get; set; }
    }
}
