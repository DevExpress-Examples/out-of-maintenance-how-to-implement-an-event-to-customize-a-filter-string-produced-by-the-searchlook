using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DXSample {
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
        }

        private void OnUpdateDisplayFilter(object sender, DisplayFilterEventArgs e)
        {
            if (e.FilterText != string.Empty)
                e.FilterText = '"' + e.FilterText + '"';
        }
    }
}
