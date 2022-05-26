﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DCMS.SE.Data.Inventory
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        public int AccountGroupId { get; set; }
        [Required]
        public string ManufacturerName { get; set; }
        [Required]
        public string ManufacturerCode { get; set; }
        public int StoreId { get; set; }
        public Decimal OpeningBalance { get; set; }
        public bool IsDefault { get; set; }
        public string CrOrDr { get; set; }
        public string Narration { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
