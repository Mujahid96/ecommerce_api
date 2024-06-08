using System.Collections.Generic;

namespace Ecommerce_Shop.Models
{
    public class BaseEntity
    {
        #region "Optional Attribute For Future Usages"
        public string? Attribute1 { get; set; }
        public string? Attribute2 { get; set; }
        public string? Attribute3 { get; set; }
        public string? Attribute4 { get; set; }
        public string? Attribute5 { get; set; }
        public string? Attribute6 { get; set; }
        public string? Attribute7 { get; set; }
        public string? Attribute8 { get; set; }
        public string? Attribute9 { get; set; }
        public string? Attribute10 { get; set; }
        #endregion
        public int? CreatedBy { get; set; }
        public virtual DateTime? CreationDate { get; set; }
        public int? LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? BranchId { get; set; }

    }
}
