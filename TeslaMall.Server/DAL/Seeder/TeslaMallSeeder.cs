using Microsoft.EntityFrameworkCore;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.DAL.Seeder;

public sealed class TeslaMallSeeder
{
    public void SeedData(ModelBuilder builder)
    {
        builder.Entity<Location>().HasData(
            [
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1c"), LocationName = "Palma Airport", LocationDescription = "Sunny airport welcoming any visitors to join great vacation!" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1a"), LocationName = "Palma City Center", LocationDescription = "City center buzzing with life and music. Worth checking out!" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1b"), LocationName = "Alcudia", LocationDescription = "Best coctails, parties and company. Don't wait and go!" },
                new Location() { Id = Guid.Parse("bddce424-3340-45bc-a4ef-02db33bc8c1d"), LocationName = "Manacor", LocationDescription = "Sandy beach, full sun and relax. Rent a car and go!" }
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
