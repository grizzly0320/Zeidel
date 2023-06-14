using Microsoft.Data.SqlClient;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Zeidel
{
    public partial class Form1 : Form
    {
        BDConnector connector;
        Account account;
        public Form1()
        {
            InitializeComponent();
            this.connector = new BDConnector("(localdb)\\mssqllocaldb", "Zeidel");
            iDToolStripMenuItem.Visible = false;
        }

        public Form1(Account account)
        {
            InitializeComponent();
            this.account = account;
            this.signInToolStripMenuItem.Visible = false;
            this.registerToolStripMenuItem.Visible = false;
            this.iDToolStripMenuItem.Visible = true;
            this.iDToolStripMenuItem.Text += $" {this.account.Id}";
        }

        private void SignIn(object sender, EventArgs e)
        {
            //try
            //{
            //    this.account = this.connector.Select("Name", this.nameToolStripMenuItem.Text);
            //    Form1 form1 = new Form1(this.account);
            //    form1.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ERROR", ex.Message, MessageBoxButtons.OKCancel);
            //}
            try
            {
                this.account = connector.Select("Name", this.nameToolStripMenuItem.Text);
                Form1 form1 = new Form1(this.account);
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel);
            }
        }

        private void Register(object sender, EventArgs e)
        {
            try
            {
                if (connector.CheckAccount("Name", this.nameToolStripMenuItem1.Text))
                {
                    this.account = connector.Insert(this.nameToolStripMenuItem1.Text, this.passwordToolStripMenuItem1.Text);
                    Form1 form1 = new Form1(this.account);
                    form1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel);
            }
        }

        private void AddColumn()
        {

        }

        private void DeleteColumn()
        {

        }
    }
}