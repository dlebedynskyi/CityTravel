// <auto-generated />
namespace CityTravel.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class PriceForRoute : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201202171548411_PriceForRoute"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}