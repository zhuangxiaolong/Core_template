﻿using dotnet_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_Mapping
{
    public class UserMapping : EntityTypeConfiguration<UserInfo>
    {
        public UserMapping()
        {
            ToTable("tUser");
            HasKey(t => t.Id);

            //primary key
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("id");
            //columns
            Property(t => t.Name).HasColumnName("Name").HasMaxLength(100).IsOptional();
            Property(t => t.Pw).HasColumnName("Pw").IsOptional();
        }
    }
}
