using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjectCourse.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name should be between {2} and {1}")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="Enter a valid email")]
        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Base salary required")]
        [Display(Name="Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float BaseSalary { get; set; }

        [Required(ErrorMessage = "Birth date required")]
        [Display(Name="Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, float baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSaleRecord(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSaleRecord(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public float TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(p => p.Date >= initial && p.Date <= final).Sum(p => p.Amount);
        }


    }
}
