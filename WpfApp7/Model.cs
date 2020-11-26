using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class EmployInfo
    {
        public string DeptName { get; set; }
        public string EmployName { get; set; }
        public string Gender { get; set; }
        [Key]
        public string UserCode { get; set; }
        public int RuleCode { get; set; }
        public int OrderCode { get; set; }
        public int NewCode { get; set; }
        public int? NewCode2 { get; set; }
        public int NewCode3 { get; set; } = 0;
    }
    public class DeptInfo
    {
        public string SubDept { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string RuleCode { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
    }
}
