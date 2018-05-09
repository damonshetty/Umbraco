using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Project.PetaPoco
{
    [TableName("PetaPocoHomePageWhatsNew")]
    [PrimaryKey("Id", autoIncrement = true)]
    [ExplicitColumns]
    public class PetaPocoHomePageWhatsNew
    {
        [Column("Id")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        [Column("PageId")]
        public int PageId { get; set; }

        [Column("Title")]
        public string Title { get; set; }
        
        [Column("Description")]
        public string Description { get; set; }

        [Column("DateTime")]
        public DateTime DateTime { get; set; }
    }
}