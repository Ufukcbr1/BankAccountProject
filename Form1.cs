using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountsProject1
{
    public partial class Form1 : Form
    {


        AccountDal _accountDal = new AccountDal();

        public Form1()
        {
            InitializeComponent();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAccounts();//Veri kaynağı olarak accountDal'ın getAll() methodu'nu gösterdik



        }

        private void LoadAccounts()
        {
            dgwAccounts.DataSource = _accountDal.GetAll();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAccountType_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _accountDal.Add(new Account
            {

                CustomerName = tbxName.Text,//Kullanıcı text alanına ne yazarsa atanıyor
                Balance = Convert.ToDecimal(tbxBalance.Text),
                PhoneNumber=Convert.ToInt32(tbxNumber.Text),
                AccountType=tbxType.Text,
                Location=tbxLocation.Text
                

            });

            LoadAccounts();
            MessageBox.Show("Customer Added ");

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void dgwAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwAccounts.CurrentRow.Cells[1].Value.ToString();//Seçili olan satırın 1.hücresinin valuesini string'e çevir
            tbxLocationUpdate.Text = dgwAccounts.CurrentRow.Cells[2].Value.ToString();
           tbxBalanceUpdate.Text = dgwAccounts.CurrentRow.Cells[3].Value.ToString();
           tbxNumberUpdate.Text = dgwAccounts.CurrentRow.Cells[4].Value.ToString();
            tbxTypeUpdate.Text = dgwAccounts.CurrentRow.Cells[5].Value.ToString();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account
                {
            
                Id=Convert.ToInt32( dgwAccounts.CurrentRow.Cells[0].Value),
                CustomerName = tbxNameUpdate.Text,
                Location= tbxLocationUpdate.Text,
                Balance=  Convert.ToDecimal(tbxBalanceUpdate.Text),
               PhoneNumber =Convert.ToInt32(tbxNumberUpdate.Text),
                AccountType = tbxTypeUpdate.Text



        };
            _accountDal.Update(account);
             LoadAccounts();

               MessageBox.Show("Updated!");



        }

      

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwAccounts.CurrentRow.Cells[0].Value);
            _accountDal.Delete(id);
            LoadAccounts();
            MessageBox.Show("Deleted");
        }
    }
}
