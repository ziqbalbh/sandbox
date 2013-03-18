using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBox
{
    class EmailItemConfiguration : EntityTypeConfiguration<EmailItem>
    {
        public EmailItemConfiguration()
        {
            // table
            this.ToTable("email_addresses");

            //primary key
            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasColumnName("email_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                
            this.Property(t => t.Address)
                .HasColumnName("email_address")
                .HasMaxLength(256);

            this.Property(t => t.Label)
                .HasColumnName("email_type")
                .HasMaxLength(50)
                .IsRequired();            
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
