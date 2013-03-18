using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace consoleBox
{
    class PersonItemConfiguration : EntityTypeConfiguration<PersonItem>
    {
        public PersonItemConfiguration()
        {
            // table
            this.ToTable("people");

            //primary key
            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasColumnName("person_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                
            this.Property(t => t.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(100);
            this.Property(t => t.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(100)
                .IsRequired();
            this.Property(t => t.Gender)
                .HasColumnName("gender")
                .HasMaxLength(10)
                .IsOptional();
            this.Property(t => t.BirthDate)
                .HasColumnName("birth_date")
                .HasColumnType("date")
                .IsOptional();

            this.HasMany(p => p.Emails)
                .WithRequired()
                .Map(t => t.MapKey("person_id"));                
        }
    }
}



//System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.CascadableNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ManyNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.OptionalNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.RequiredNavigationPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.StructuralTypeConfiguration
//System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration
