using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace VehicleLoanSystem.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        // [Required]
        // [DisplayName("Middle Name")]
        // public string? MiddleName { get; set; }


        [Required]
        [DisplayName("Gender")]
        public string? Gender { get; set; }
        
        [DisplayName("Email")]
        [Required(ErrorMessage = "The Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string? Phone { get; set; }
        [Required]
        [DisplayName("Loan Plan")]
        public int LoanPlanId { get; set; }
        [Required]
        [DisplayName("Salary")]
        public double Salary { get; set; }
        [Required]
        [DisplayName("Loan Type")]
        public int LoanTypeId { get; set; }
        [Required]
        [DisplayName("Loan Purpose")]
        public string? LoanPurpose { get; set; }
        [Required]
        [DisplayName("Loan Amount")]
        public double LoanAmount { get; set; }

        [DefaultValue("PENDING")]
        [DisplayName("Loan Grant")]
        public string? LoanGrant { get; set; }

        [DisplayName("Loan Date")]
        public DateTime LoanDate { get; set; }
        [DefaultValue(0)]
        [DisplayName("Total Payable Amount")]
        public double TotalPayableAmount { get; set; }
        [DefaultValue(0)]
        [DisplayName("Monthly Payable Amount")]
        public double MonthlyPayableAmount { get; set; }
        [DefaultValue(0)]
        [DisplayName("Monthly Penalty")]
        public double MonthlyPenalty { get; set; }
        [DisplayName("Rejection Reason")]
        [DefaultValue("None")]
        public string? RejectionReason { get; set; }
        [DisplayName("User Id")]
        public int UserId { get; set; }
        

    }
}


// using System;
// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;

// namespace VehicleLoanSystem.Models
// {
//     public class Loan
//     {
//         [Key]
//         public int Id { get; set; }

//         [Required(ErrorMessage = "First Name is required")]
//         [DisplayName("First Name")]
//         public string FirstName { get; set; }

//         [Required(ErrorMessage = "Last Name is required")]
//         [DisplayName("Last Name")]
//         public string LastName { get; set; }

//         [Required(ErrorMessage = "Middle Name is required")]
//         [DisplayName("Middle Name")]
//         public string MiddleName { get; set; }

//         [Required(ErrorMessage = "Gender is required")]
//         [DisplayName("Gender")]
//         public string Gender { get; set; }

//         [Required(ErrorMessage = "Email Address is required")]
//         [EmailAddress(ErrorMessage = "Invalid Email Address")]
//         [DisplayName("Email")]
//         public string Email { get; set; }

//         [Required(ErrorMessage = "Phone Number is required")]
//         [DisplayName("Phone Number")]
//         public string Phone { get; set; }

//         [Required(ErrorMessage = "Loan Plan is required")]
//         [DisplayName("Loan Plan")]
//         public int LoanPlanId { get; set; }

//         [Required(ErrorMessage = "Salary is required")]
//         [DisplayName("Salary")]
//         public double Salary { get; set; }

//         [Required(ErrorMessage = "Loan Type is required")]
//         [DisplayName("Loan Type")]
//         public int LoanTypeId { get; set; }

//         [Required(ErrorMessage = "Loan Purpose is required")]
//         [DisplayName("Loan Purpose")]
//         public string LoanPurpose { get; set; }

//         [Required(ErrorMessage = "Loan Amount is required")]
//         [DisplayName("Loan Amount")]
//         public double LoanAmount { get; set; }

//         [DisplayName("Loan Grant")]
//         public string? LoanGrant { get; set; } // Nullable string

//         [DisplayName("Loan Date")]
//         public DateTime LoanDate { get; set; }

//         [DisplayName("Total Payable Amount")]
//         public double TotalPayableAmount { get; set; }

//         [DisplayName("Monthly Payable Amount")]
//         public double MonthlyPayableAmount { get; set; }

//         [DisplayName("Monthly Penalty")]
//         public double MonthlyPenalty { get; set; }

//         [DisplayName("Rejection Reason")]
//         public string? RejectionReason { get; set; } // Nullable string

//         [DisplayName("User Id")]
//         public int UserId { get; set; }
//     }
// }
