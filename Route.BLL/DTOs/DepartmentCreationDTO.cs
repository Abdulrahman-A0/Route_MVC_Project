using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.BLL.DTOs
{
    public class DepartmentCreationDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
