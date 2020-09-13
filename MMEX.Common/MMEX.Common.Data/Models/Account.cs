using MMEX.Common.Data.Business.Contracts;
using SQLite;

namespace MMEX.Common.Data.Models
{
    [Table("ACCOUNTLIST_V1")]
    public class Account : IEntity
    {
        public Account()
        {
        }

        [Column("ACCOUNTID"),
            PrimaryKey,
            AutoIncrement,
            NotNull]
        public int Id { get; set; }

        [Column("ACCOUNTNAME"),
            NotNull,
            Collation("NOCASE"),
            Indexed(Name = "IDX_ACCOUNTLIST_ACCOUNTNAME", Order = 0, Unique = true)]
        public string Name { get; set; }

        [Column("ACCOUNTTYPE"),
            NotNull,
            Indexed(Name = "IDX_ACCOUNTLIST_ACCOUNTTYPE", Order = 0, Unique = false)]
        public string Type { get; set; }

        [Column("ACCOUNTNUM")]
        public string Number { get; set; }

        [Column("STATUS"),
            NotNull]
        public string Status { get; set; }

        [Column("NOTES")]
        public string Notes { get; set; }

        [Column("HELDAT")]
        public string HeldAt { get; set; }

        [Column("WEBSITE")]
        public string Website { get; set; }

        [Column("CONTACTINFO")]
        public string ContactInfo { get; set; }

        [Column("ACCESSINFO")]
        public string AccessInfo { get; set; }

        [Column("INITIALBAL")]
        public decimal InitialBalance { get; set; }

        [Column("FAVORITEACCT"),
            NotNull]
        public string Favorite { get; set; }

        [Column("CURRENCYID"),
            NotNull]
        public int Currency { get; set; }

    }
}
