using EShop.ENTITIES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.CONF.Configurations
{
    public class ProductImageConfiguration : BaseConfiguration<ProductImage>
    {
        public override void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ImagePath).HasColumnType("nvarchar").IsRequired();
            builder.Property(x=>x.ProductID).HasColumnType("int").IsRequired();
        }
    }
}
