using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditTable
    {
        DateTime? CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        string CraetedBy { get; set; }
        [MaxLength(256)]
        string UpdateBy { get; set; }
        bool Status { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
