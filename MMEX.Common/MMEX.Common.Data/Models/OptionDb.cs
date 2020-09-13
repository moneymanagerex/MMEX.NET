using MMEX.Common.Data.Business.Contracts;
using SQLite;

namespace MMEX.Common.Data.Models
{
    [Table("INFOTABLE_V1")]
    public class OptionDb : IEntity
    {
        public OptionDb()
        {
        }

        [Column("INFOID"),
            PrimaryKey,
            AutoIncrement,
            NotNull]
        public int Id { get; set; }

        [Column("INFONAME"),
            NotNull,
            Unique,
            Collation("NOCASE"),
            Indexed(Name = "IDX_INFOTABLE_INFONAME", Order = 0, Unique = false)]
        public string Name { get; set; }

        [Column("INFOVALUE"), NotNull]
        public string Type { get; set; }
    }
}
