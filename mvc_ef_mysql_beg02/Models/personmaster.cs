namespace mvc_ef_mysql_beg02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("personmaster")]
    public partial class personmaster
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string FIRSTNAME { get; set; }

        [StringLength(10)]
        public string LASTNAME { get; set; }

        [StringLength(20)]
        public string ADDRESS1 { get; set; }

        [StringLength(100)]
        public string ADDRESS2 { get; set; }

        public virtual address address { get; set; }
    }
}
