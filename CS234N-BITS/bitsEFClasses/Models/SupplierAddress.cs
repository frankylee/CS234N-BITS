﻿using System;
using System.Collections.Generic;

namespace bitsEFClasses.Models
{
    public partial class SupplierAddress
    {
        public int SupplierId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Supplier Supplier { get; set; }

        public override string ToString()
        {
            return SupplierId + ", " + AddressId + ", " + AddressTypeId;
        }
    }
}
