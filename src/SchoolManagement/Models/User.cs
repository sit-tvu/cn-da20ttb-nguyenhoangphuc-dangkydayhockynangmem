﻿using System;
using System.Collections.Generic;

namespace SchoolManagement.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<GiaoVien> GiaoViens { get; set; } = new List<GiaoVien>();

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
