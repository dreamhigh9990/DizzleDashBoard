using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizzleDashBoard.Models
{
    public class Hospital
    {
        public int amountOfPatients { get; set; }
        public int departmentCapacity { get; set; }
        public string departmentName { get; set; }
        public string governmentHospital { get; set; }
        public int governmentHospitalId { get; set; }
        public string hospital { get; set; }
        public int id { get; set; }
        public string reportedOn { get; set; }
    }
}
