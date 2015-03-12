using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EveAI.Live;
using EveAI.Live.Character;


namespace WindowsFormsApplication1
{
    public partial class ApiKeyForm : Form
    {
        public static List<EveAI.Live.Account.AccountCharacter> Characters;
        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EveApi api = new EveApi("Eve Uni Project.", Convert.ToInt64(txtKeyID.Text), txtVcode.Text);
            Characters = api.GetAccountCharacters();
            CharSelectForm Form2 = new CharSelectForm(api);

            if (api.GetAccountStatus().LogonCount.ToString() == "0")
            {
                MessageBox.Show("Please check your internet connection.");
            }
            else
            {
                Form2.Show();
                this.Hide();
            }
                
        }
    }
}
