using MMEX.Common.Data.Business.Contracts;
using SQLite;

namespace MMEX.Common.Data.Models
{
    [Table("SETTING_V1")]
    public class OptionLocal : IEntity
    {
        public OptionLocal()
        {
        }

        [Column("SETTINGID"),
            PrimaryKey,
            NotNull]
        public int Id { get; set; }

        [Column("SETTINGNAME"),
            NotNull,
            Unique,
            Collation("NOCASE"),
            Indexed(Name = "IDX_INFOTABLE_INFONAME", Order = 0, Unique = false)]
        public string Name { get; set; }

        [Column("SETTINGVALUE")]
        public string Value { get; set; }
    }
}
