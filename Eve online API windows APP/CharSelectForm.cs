using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CharSelectForm : Form
    {
        CheckBox[] checkBoxes;
        EveAI.Live.EveApi Api;
        public CharSelectForm(EveAI.Live.EveApi Api)
        {
            InitializeComponent();
            this.Api = Api;

            
        }

        private void EveAPI2_Load(object sender, EventArgs e)
        {
            checkBoxes = new CheckBox[] { Cbox1, Cbox2, Cbox3 };
            for (int i = 0; i < ApiKeyForm.Characters.Count; i++)
            {
                checkBoxes[i].Visible = true;
                checkBoxes[i].Text = ApiKeyForm.Characters[i].CharacterName.ToString();
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<EveAI.Live.Account.AccountCharacter> charactersToShow = new List<EveAI.Live.Account.AccountCharacter>();
            bool NoneSelected = true;
            for(int i = 0; i < ApiKeyForm.Characters.Count; i++)
            {
                if(checkBoxes[i].CheckState == CheckState.Checked)
                {
                    charactersToShow.Add(ApiKeyForm.Characters[i]);
                    NoneSelected = false;
                }
            }
            if (NoneSelected == true)
            {
                MessageBox.Show("Please select a character.");
            }
            else
            {

                MainForm Main = new MainForm(this.Api,charactersToShow);
                Main.Show();
                this.Hide();

            }
        }

        private void EveAPI2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
