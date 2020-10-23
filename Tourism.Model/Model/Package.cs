using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PackageType { get; set; }
        public string Destination { get; set; }
        public decimal TotalDays { get; set; }
        public decimal TotalNights { get; set; }
        public decimal PerPersonAmount { get; set; }
        public string Inclusion { get; set; }
        public string Exclusion { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        List<PackageContent> PackageContents { get; set; }

    }
}
