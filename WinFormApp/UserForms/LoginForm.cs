using System;
using System.Windows.Forms;

namespace WinFormApp.UserForms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}