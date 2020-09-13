using MMEX.Common.Data.Business.Contracts;
using SQLite;

namespace MMEX.Common.Data.Models
{
    [Table("CURRENCYFORMATS_V1")]
    public class Currency : IEntity
    {
        public Currency()
        {
        }

        [Column("CURRENCYID"),
            PrimaryKey,
            AutoIncrement,
            NotNull]
        public int Id { get; set; }

        [Column("CURRENCYNAME"),
            NotNull,
            Collation("NOCASE"),
            Indexed(Name = "IDX_CURRENCYFORMATS_ACCOUNTNAME", Order = 0, Unique = true)]
        public string Name { get; set; }

        [Column("PFX_SYMBOL")]
        public string PfxSymbol { get; set; }

        [Column("SFX_SYMBOL")]
        public string SfxSymbol { get; set; }

        [Column("DECIMAL_POINT")]
        public string DecimalPoint { get; set; }

        [Column("GROUP_SEPARATOR")]
        public string GroupSeparator { get; set; }

        [Column("UNIT_NAME"),
            Collation("NOCASE"),]
        public string UnitName { get; set; }

        [Column("CENT_NAME"),
            Collation("NOCASE"),]
        public string CentName { get; set; }

        [Column("SCALE")]
        public int Scale { get; set; }

        [Column("BASECONVRATE")]
        public decimal BaseConvRate { get; set; }

        [Column("CURRENCY_SYMBOL"),
            NotNull,
            Collation("NOCASE"),
            Indexed(Name = "IDX_CURRENCYFORMATS_SYMBOL", Order = 0, Unique = true)]
        public string Symbol { get; set; }
    }
}
