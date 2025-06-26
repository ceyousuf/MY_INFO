using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_INFO
{
    public partial class frmMyInfo : Form
    {
        public frmMyInfo()
        {
            InitializeComponent();
        }
// this is test for update
        private void btnConvert_Click(object sender, EventArgs e)
        {
            SecretKey secretkey = new SecretKey();
            if(rdoEncrypt.Checked==true)
            {
                
                txtOutputData.Text = secretkey.my_Encrypt(txtInputData.Text, txtSecretKey.Text);

            }
            else if (rdoDecrypt.Checked == true)
            {
                txtOutputData.Text = secretkey.my_Decrypt(txtInputData.Text, txtSecretKey.Text);
            }
        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtOutputData.Text);
        }
    }
}
