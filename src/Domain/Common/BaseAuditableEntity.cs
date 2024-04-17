using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Domain.Common
{
    public class BaseAuditableEntity :BaseEntity
    {
        public string CreatedBy { get; set; } = null!;
        public string IP { get; set; } = null!;
        public DateTime Created { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
    }
}
