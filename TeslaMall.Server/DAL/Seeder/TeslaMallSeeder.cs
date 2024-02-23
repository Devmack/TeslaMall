using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Seeder;

public sealed class TeslaMallSeeder
{
    public void SeedData(ModelBuilder builder)
    {
        builder.Entity<Location>().HasData(
            [
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1c"), LocationName = "Palma Airport" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1a"), LocationName = "Palma City Center" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1b"), LocationName = "Alcudia" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1d"), LocationName = "Manacor" }
            ]);


        builder.Entity<TeslaCar>().HasData(
            [
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1c") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1c") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model X", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1c") },

                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model Y", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1a") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model Y", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1a") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model X", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1a") },

                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model Y", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1b") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model 3", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1b") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1b") },

                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1d") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1d") },
                new TeslaCar() { Id = Guid.NewGuid(), ModelName = "Model S", RelatedLocationId = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1d") },
            ]);
    }
}
