using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
    public class PackageContent
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public string ContentLink { get; set; }

        List<Package> packages { get; set; }
    }
}
