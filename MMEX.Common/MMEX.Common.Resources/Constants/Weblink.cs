using MMEX.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace MMEX.Common.Resources.Constants
{
    public class constWeblink
    {
        public static readonly string WebSite = addReferralToURL("http://www.moneymanagerex.org", enCampaign.Website);
        //public static readonly string Update = wxString::Format("http://www.moneymanagerex.org/version.php?Version=%s", mmex::version::string);
        //public static readonly string UpdateLinks = wxString::Format("http://www.moneymanagerex.org/version.php?Version=%s&Links=true", mmex::version::string);
        //public static readonly string Changelog = wxString::Format("http://www.moneymanagerex.org/version.php?Version=%s&ChangeLog=", mmex::version::string);
        //public static readonly string UsageStats = "http://usagestats.moneymanagerex.org/API/main_stats_v1.php";
        public static readonly string Download = addReferralToURL("http://www.moneymanagerex.org/download", enCampaign.Download);
        public static readonly string News = addReferralToURL("http://www.moneymanagerex.org/news", enCampaign.News);
        public static readonly string NewsRSS = "http://www.moneymanagerex.org/news?format=feed";
        public static readonly string Forum = addReferralToURL("http://forum.moneymanagerex.org", enCampaign.Forum);
        public static readonly string Wiki = "http://wiki.moneymanagerex.org";
        public static readonly string BugReport = "http://bugreport.moneymanagerex.org";
        public static readonly string Donate = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=moneymanagerex%40gmail%2ecom&lc=US&item_name=MoneyManagerEx&no_note=0&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest";
        public static readonly string Twitter = "https://twitter.com/MoneyManagerEx";
        public static readonly string Facebook = "http://www.facebook.com/pages/Money-Manager-Ex/242286559144586";
        //public static readonly string YahooQuotes = "http://download.finance.yahoo.com/d/quotes.csv?s=%s&f=sl1c4n&e=.csv";
        //public static readonly string YahooQuotesHistory = "http://ichart.finance.yahoo.com/table.csv?s=";
        public static readonly string BceCurrencyHistory = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml";
        public static readonly string GooglePlay = "https://play.google.com/store/apps/details?id=com.money.manager.ex";
        public static readonly string WebApp = "https://github.com/moneymanagerex/web-money-manager-ex";
        public static readonly string DefStockUrl = "http://finance.yahoo.com/echarts?s=%s";

        private enum enCampaign
        {
            [Display(Description = "Website")]
            Website,
            [Display(Description = "Download")]
            Download,
            [Display(Description = "News")]
            News,
            [Display(Description = "Forum")]
            Forum,
        }

        private static string addReferralToURL (string Url, enCampaign campaign)
        {
            /*
                With Google Analytics it's possible to send referral data in URL to distinguish between visitor source
                https://support.google.com/analytics/answer/1033867?hl=en
            */

            return string.Format("{0}?utm_campaign=Application_{1}&utm_source={2}&utm_medium={3}",
                Url, DataAnnotationsExtensions.GetDescription(constPlatform.getCurrentPlatform()),
                DataAnnotationsExtensions.GetDescription(campaign), "MMEX");
        }
    }
}
