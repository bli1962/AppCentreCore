﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.AppCenter
{
    [Index(nameof(RoleId), Name = "IX_AspNetUserRoles_RoleId")]
    public partial class AspNetUserRole
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(AspNetRole.AspNetUserRoles))]
        public virtual AspNetRole Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUser.AspNetUserRoles))]
        public virtual AspNetUser User { get; set; }
    }
}
