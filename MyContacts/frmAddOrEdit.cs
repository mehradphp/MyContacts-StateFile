using MyContacts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form

    {
        IContactRepository repository;
        public int contactId;

        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsReposetory();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess;
    
                if (contactId == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }
                else
                {
                    isSuccess = repository.update(contactId,txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);

                }

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("عملیات انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            
            
            };
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if(contactId==0)
            {
                this.Text = "افزودن";

            }
            else
            {
                this.Text = "ویرایش";

                DataTable dt = repository.SelectRow(contactId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtMobile.Text = dt.Rows[0][2].ToString();
                txtFamily.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAge.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "ویرایش";

            }
        }

        bool ValidateInputs()
        {
            bool isValid = true;
            if (txtName.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFamily.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtAge.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMobile.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
