﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dreamer.Data
{
    public class LoginRequest
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public long CompanyId { get; set; }
        public bool IsActive { get; set; }


    }
}
