namespace BeGorgeous.Data.Configurations
{
    using BeGorgeous.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SalonTreatmentConfiguration : IEntityTypeConfiguration<SalonTreatment>
    {
        public void Configure(EntityTypeBuilder<SalonTreatment> salonTreatment)
        {
            salonTreatment.HasKey(st => new { st.SalonId, st.TreatmentId });
        }
    }
}
