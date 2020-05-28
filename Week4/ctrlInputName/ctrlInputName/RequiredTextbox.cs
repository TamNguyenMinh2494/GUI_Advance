using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrlInputName
{
    public partial class RequiredTextbox: TextBox
    {
        private bool isRequired { get; set; }
        public RequiredTextbox()
        {
            InitializeComponent();
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if(isRequired && Text.Length == 0)
            {
                e.Cancel = true;
                base.OnValidating(e);
            }
        }
        private void RequiredTextbox_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Name is required!");
        }
    }
}
