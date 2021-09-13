using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class stateFrom : Form
    {

        IstateRepository repository;


        public stateFrom()
        {
            InitializeComponent();

            repository = new StateReposetory();
        }

        private void stateFrom_Load(object sender, EventArgs e)
        {
            BindGridFile();
        }

        private void BindGridFile()
        {
            dgState.AutoGenerateColumns = false;
            dgState.Columns[0].Visible = false;
            dgState.DataSource = repository.SelectAll();
        }

        private void btnRefreshFile_Click(object sender, EventArgs e)
        {
            BindGridFile();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
 
            frmAddOrEddit frmAddState = new frmAddOrEddit();
            frmAddState.ShowDialog();

            if(frmAddState.DialogResult== DialogResult.OK)
            {
                BindGridFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgState.CurrentRow != null)
            {

                string CodeFile = dgState.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"ایا از حذف {CodeFile} مطمعن هستید ؟","توجه",MessageBoxButtons.YesNo) ==DialogResult.Yes)
                {

                    int stateId = int.Parse(dgState.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(stateId);
                    BindGridFile();
                }
            }
            else
            {
                MessageBox.Show("یک شخص را از لیست انتخاب کنید");

            }
        }

        private void dgState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEddit_Click(object sender, EventArgs e)
        {
            if(dgState.CurrentRow != null)
            {
                int stateID = int.Parse(dgState.CurrentRow.Cells[0].Value.ToString());

                frmAddOrEddit frm = new frmAddOrEddit();
                frm.stateId = stateID;


                if(frm.ShowDialog() == DialogResult.OK)
                {
                    BindGridFile();
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgState.DataSource = repository.SearchFile(txtSearch.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog(){Filter = "Excel workbook|*.xlsx"})
            {
                if(sfd.ShowDialog()== DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook =new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.repository.SelectAll().Copy(),"file");
                            workbook.SaveAs(sfd.FileName);

                        }
                        MessageBox.Show("das ist ok","meesage",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                    }
                }
            }
        }



        private void serachBtn_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://www.google.com");

            if (checkMetraj.Checked == true)
            {

            dgState.DataSource = repository.SearchParams((int)serNum1.Value,(int)serNum2.Value);


            }
            else
            {
                dgState.DataSource = repository.SearchMetraj((int)serNum1.Value, (int)serNum2.Value);

            }



        }
    }
}
