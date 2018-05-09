using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Project.PetaPoco
{
    [TableName("PetaPocoUserProfiles")]
    [PrimaryKey("Id", autoIncrement = true)]
    [ExplicitColumns]
    public class PetaPocoUserProfile
    {
        [Column("Id")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        [Column("Firstname")]
        public string Firstname { get; set; }
        
        [Column("Surname")]
        public string Surname { get; set; }

        [Column("JobTitle")]
        public string JobTitle { get; set; }
        
        [Column("Summary")]
        public string Summary { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }
}