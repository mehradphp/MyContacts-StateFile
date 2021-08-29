using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEddit : Form
    {
        IstateRepository repository;

        public int stateId = 0;
        public frmAddOrEddit()
        {
            InitializeComponent();

            repository = new StateReposetory();
        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrEddit_Load(object sender, EventArgs e)
        {

            if(stateId == 0)
            {
                this.Text = "افزودن شخص جدید";

            }
            else
            {
                this.Text = "ویرایش";

                DataTable dt = repository.SelectRow(stateId);

                CodeFile.Text = dt.Rows[0][1].ToString();
                Address.Text = dt.Rows[0][2].ToString();

                MalekName.Text = dt.Rows[0][3].ToString();
                Price.Text = dt.Rows[0][4].ToString();
                Mobile.Text = dt.Rows[0][5].ToString();
                Category.Text = dt.Rows[0][6].ToString();
                btnSubmitState.Text = "ویرایش";



            }
        }

        bool ValidateInputsState()
        {



            if (CodeFile.Text == "")
            {
                MessageBox.Show("لطفا کد فایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (MalekName.Text == "")
            {
                MessageBox.Show("لطفا نام مالک را وارد کنید وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void btnSubmitState_Click(object sender, EventArgs e)
        {
            if(ValidateInputsState())
            {
                bool isSuccess;
                if(stateId == 0)
                {
                    isSuccess  = repository.Insert(CodeFile.Text, Address.Text, MalekName.Text, (int)Price.Value, Mobile.Text, Category.Text);

                }
                else
                {
                    isSuccess = repository.Update(stateId,CodeFile.Text,Address.Text,MalekName.Text,(int)Price.Value,Mobile.Text, Category.Text);
                }

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات انجام شد", "موفقیت", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
    }
}
