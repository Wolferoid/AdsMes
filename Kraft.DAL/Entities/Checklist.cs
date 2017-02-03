using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.DAL.Entities
{
    public class Checklist : BaseEntity
    {
        public DateTime DateTime { get; set; }

        public string Conformity { get; set; }

        public string Top { get; set; }

        public string Bottom { get; set; }

        public string Left { get; set; }

        public string Right { get; set; }

        public int Length { get; set; }

        public string Barcode { get; set; }

        public string UserName { get; set; }

        public string Workplace { get; set; }

        public int ShiftNumber { get; set; }
    }
}
