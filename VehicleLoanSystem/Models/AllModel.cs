// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Threading.Tasks;

// namespace VehicleLoanSystem.Models
// {
//     [Keyless]
//     public class AllModel
//     {
        
//     public List<Loan> Loans { get; set; }
//     public List<LoanPlan> LoanPlans { get; set; }
//     public List<LoanType> LoanType { get; set; }
//     public List<Payment> Payment { get; set; }
//     public List<UserAccount> Account { get; set; }
// }
// }

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleLoanSystem.Models
{
    [Keyless]
    public class AllModel
    {
        public List<Loan>? Loans { get; set; }
        public List<LoanPlan>? LoanPlans { get; set; }
        public List<LoanType>? LoanTypes { get; set; }
        public List<Payment>? Payments { get; set; }
        public List<UserAccount>? Accounts { get; set; }
    }
}

