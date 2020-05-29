using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGUI.EventsLib;

namespace XMLGUI.Forms
{
    public partial class QuantityThreads : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;
        public QuantityThreads()
        {
            InitializeComponent();
        }

        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBox.Text));
            this.Close();
        }

        private void QuantityThreads_Load(object sender, EventArgs e)
        {

        }

        private void paramTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(paramTxtBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                paramTxtBox.Text = paramTxtBox.Text.Remove(paramTxtBox.Text.Length - 1);
            }
        }
    }
}
