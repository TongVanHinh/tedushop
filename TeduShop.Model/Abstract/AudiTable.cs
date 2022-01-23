using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class AudiTable : IAuditTable
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string CraetedBy { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}
