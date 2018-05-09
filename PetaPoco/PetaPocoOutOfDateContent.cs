using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Project.PetaPoco
{
    [TableName("PetaPocoOutOfDateContent")]
    [PrimaryKey("Id", autoIncrement = true)]
    [ExplicitColumns]
    public class PetaPocoOutOfDateContent
    {
        [Column("Id")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        [Column("PageId")]
        public int PageId { get; set; }

        [Column("Heading")]
        public string Heading { get; set; }
        
        [Column("Description")]
        public string Description { get; set; }

        [Column("Path")]
        public string Path { get; set; }

        [Column("FileName")]
        public string FileName { get; set; }

        [Column("UpdatedDateTime")]
        public DateTime UpdatedDateTime { get; set; }

        [Column("ScanDateTime")]
        public DateTime ScanDateTime { get; set; }
    }
}