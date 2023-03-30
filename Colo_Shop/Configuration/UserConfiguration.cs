﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Colo_Shop.Models;
namespace Web_Application.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Password).HasColumnType("nvarchar(MAX)");
            builder.Property(p => p.Name).HasColumnType("nvarchar(MAX)");
            builder.Property(p => p.Email).HasColumnType("nvarchar(MAX)");
            builder.Property(p => p.NumberPhone).HasColumnType("nvarchar(MAX)");
            builder.Property(p => p.Status).HasColumnType("int");
            builder.Property(x => x.ImageUser);
            builder.HasOne(p => p.Role).WithMany(p => p.Users).
                HasForeignKey(p => p.RoleId);
        }
    }
}
