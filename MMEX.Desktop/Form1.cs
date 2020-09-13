using MMEX.Common.Data.Business.Managers;
using MMEX.Common.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEX.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public AccountMngr _AccountMngr { get; set; }
        public CurrencyMngr _CurrencyMngr { get; set; }
        public string DbPath = "C:\\pippo2.mmb";

        private void button1_Click(object sender, EventArgs e)
        {
            _AccountMngr = new AccountMngr(DbPath);
            _CurrencyMngr = new CurrencyMngr(DbPath);

            Currency curr = new Currency
            {
                Name = "Currency1",
                Symbol = "CURR1"
            };
            int iCurr = _CurrencyMngr.Save(curr);

            Account acc = new Account
            {
                Name = "Prova",
                Type = "Checking",
                Status = "Open",
                Favorite = "Yes",
                Currency = iCurr
            };

            _AccountMngr.Save(acc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _AccountMngr = new AccountMngr(DbPath);
            _CurrencyMngr = new CurrencyMngr(DbPath);
            Account acc = _AccountMngr.GetAll().FirstOrDefault();
            Currency curr = _CurrencyMngr.GetById(acc.Currency);
            MessageBox.Show(string.Format("Account: {0}{1}Currency: {2}",acc.Name,Environment.NewLine,curr.Name));
        }
    }
}
