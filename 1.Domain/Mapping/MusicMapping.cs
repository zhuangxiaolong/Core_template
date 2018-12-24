using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Mapping
{
    public class MusicMapping : EntityTypeConfiguration<MusicInfo>
    {
        public MusicMapping()
        {
            ToTable("tMusic");
            HasKey(t => t.Id);

            //primary key
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("id");
            //columns
            Property(t => t.Name).HasColumnName("Name").HasMaxLength(100).IsOptional();
            Property(t => t.Price).HasColumnName("Price").IsOptional();
        }
    }
}
