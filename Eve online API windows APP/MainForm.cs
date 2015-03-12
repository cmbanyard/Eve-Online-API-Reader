using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {

        UserControl1[] userControls;
        TabPage[] tabPages;
        EveAI.Live.EveApi Api;
        Image[] levelImageArray;
        Image[] trainImageArray;
        List<EveAI.Live.Account.AccountCharacter> charactersToShow;
        Thread populateThread;
        bool isInitialised = false;
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        public MainForm(EveAI.Live.EveApi Api, List<EveAI.Live.Account.AccountCharacter> characters)
        {
            InitializeComponent();
            this.Api = Api;
            this.charactersToShow = characters;
            populateThread = new Thread(Populate_Skills);
            isInitialised = true;
           
        }

        private void safeTabControlRemoving(TabPage tabPage)
        {
            if (tabControl1.InvokeRequired)
            {
                tabControl1.Invoke(new Action<TabPage>(safeTabControlRemoving), tabPage);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage);
            }
        }

        private void safeTabControlAdding(TabPage tabAdd)
        {
            if (tabControl1.InvokeRequired)
            {
                tabControl1.Invoke(new Action<TabPage>(safeTabControlAdding), tabAdd);
            }
            else
            {
                tabAdd.AutoScroll = true;
                tabControl1.TabPages.Add(tabAdd);
            }  
        }

        private void safeTabText(TabPage tabPage, string text)
        {
            if (tabPage.InvokeRequired)
            {
                tabPage.Invoke(new Action<TabPage, string>(safeTabText), tabPage, text);
            }
            else
            {
                tabPage.Text = text;
            }
        }

        private void safeTabSelect(TabControl tabControl, TabPage tabPage)
        {
            if (tabControl.InvokeRequired)
            {
                tabControl.Invoke(new Action<TabControl, TabPage>(safeTabSelect), tabControl, tabPage);
            }
            else
            {
                tabControl.SelectedTab = tabControl.TabPages[tabControl.TabPages.IndexOf(tabPage)];
            }
        }

        private void safeLabelText(Label labelText, string text)
        {
            if (labelText.InvokeRequired)
            {
                labelText.Invoke(new Action<Label, string>(safeLabelText), labelText, text);
            }
            else
            {
                labelText.Text = text;
            }
        }

        private void safeTableLayoutAddControl(FlowLayoutPanel tableLayout, ucSkills uc)
        {
            if (tableLayout.InvokeRequired)
            {
                tableLayout.Invoke(new Action<FlowLayoutPanel, ucSkills>(safeTableLayoutAddControl), tableLayout, uc);
            }
            else
            {
                tableLayout.Controls.Add(uc);
            }
        }

        private void safeImageHide (PictureBox picBox)
        {
            if (picBox.InvokeRequired)
            {
                picBox.Invoke(new Action<PictureBox>(safeImageHide), picBox);
            }
            else
            {
                picBox.Visible = false;
            }
        }

        private void safeUcUpdate(UserControl uc)
        {
            if (uc.InvokeRequired)
            {
                uc.Invoke(new Action<UserControl>(safeUcUpdate), uc);
            }
            else
            {
                uc.Invalidate(true);
                uc.Refresh();
            }
            
        }
        
        private void Populate_Skills()
        {
            while (!isInitialised) ;
            tabPages = new TabPage[] { tab1, tab2, tab3 };
            levelImageArray = new Image[] {WindowsFormsApplication1.Properties.Resources.Level0, 
                                           WindowsFormsApplication1.Properties.Resources.Level1, 
                                           WindowsFormsApplication1.Properties.Resources.Level2,
                                           WindowsFormsApplication1.Properties.Resources.Level3,
                                           WindowsFormsApplication1.Properties.Resources.Level4,
                                           WindowsFormsApplication1.Properties.Resources.Level5 };
            trainImageArray = new Image[] {WindowsFormsApplication1.Properties.Resources.Train1,
                                           WindowsFormsApplication1.Properties.Resources.Train2,
                                           WindowsFormsApplication1.Properties.Resources.Train3,
                                           WindowsFormsApplication1.Properties.Resources.Train4,
                                           WindowsFormsApplication1.Properties.Resources.Train5 };
            userControls = new UserControl1[] { userControl11, userControl12, userControl13 };
            for (int i = 0; i < tabPages.Count(); i++)
            {
                safeTabControlRemoving(tabPages[i]);

            }
            for (int i = 0; i < charactersToShow.Count; i++)
            {
                this.Api.Authentication.CharacterID = charactersToShow[i].CharacterID;
                
                safeTabControlAdding(tabPages[i]);
                safeTabText(tabControl1.TabPages[i], charactersToShow[i].CharacterName);
                safeLabelText(userControls[i].allianceLabel,"Alliance: " + charactersToShow[i].AllianceName);
                if (userControls[i].allianceLabel.Text == "Alliance: ")
                {
                   safeLabelText(userControls[i].allianceLabel, "No Alliance");
                }
                safeLabelText (userControls[i].nameLabel, "Name: " + charactersToShow[i].CharacterName);
                safeLabelText (userControls[i].corpLabel, "Corporation: " + charactersToShow[i].CorporationName);
                safeLabelText (userControls[i].balanceLabel, this.Api.GetCharacterAccountBalance()[0].ToString());
                /// Used Substring for this because the API gives "1000 - " at the start of this string which is 7 characters.
                safeLabelText (userControls[i].balanceLabel, "Balance: " + userControls[i].balanceLabel.Text.Substring(7, userControls[i].balanceLabel.Text.Length - 7) + " isk");
                safeLabelText (userControls[i].spLabel, "Currently Training: " + this.Api.GetCharacterSkillInTraining());
                if (userControls[i].spLabel.Text == "Currently Training: ")
                {
                    safeLabelText (userControls[i].spLabel, "Currently Training: No skills currently queued.");
                }
                userControls[i].btnRefresh.Click += btnRefresh_Click;
                EveAI.Live.Character.CharacterSheet Sheet = Api.GetCharacterSheet();
                List<EveAI.Live.Character.CharacterSheet.LearnedSkill> skills = Sheet.Skills;

                List<string> generatedCategories = new List<string>();
                List<ucSkills> skillsControls = new List<ucSkills>();


                foreach (EveAI.Live.Character.CharacterSheet.LearnedSkill skill in skills)
                {
                    if (generatedCategories.Contains(skill.Skill.GroupName))
                    {
                        foreach (ucSkills skillsControl in skillsControls)
                        {
                            if (skillsControl.skillPanel.PanelTitle == skill.Skill.GroupName)
                            {
                                if (this.Api.GetCharacterSkillInTraining() != null && skill.Skill.Name == this.Api.GetCharacterSkillInTraining().Skill.Name)
                                {

                                    skillsControl.skillTable.Rows.Add(skill.Skill.Name, trainImageArray[skill.Level]);
                                }

                                else
                                {
                                    skillsControl.skillTable.Rows.Add(skill.Skill.Name, levelImageArray[skill.Level]);
                                }

                            }
                        }
                    }
                    else
                    {
                        generatedCategories.Add(skill.Skill.GroupName);
                        ucSkills skillsControl = new ucSkills();
                        skillsControl.skillPanel.PanelTitle = skill.Skill.GroupName;
                        if (this.Api.GetCharacterSkillInTraining() != null && skill.Skill.Name == this.Api.GetCharacterSkillInTraining().Skill.Name)
                        {
                            skillsControl.skillTable.Rows.Add(skill.Skill.Name, trainImageArray[skill.Level]);

                        }
                        else
                        {
                            skillsControl.skillTable.Rows.Add(skill.Skill.Name, levelImageArray[skill.Level]);
                        }

                        skillsControls.Add(skillsControl);
                        
                    }
                }
                // sort generatedCategories a-z
                generatedCategories.Sort();
                // change foreach loop to loop through strings in generatedCategories
                int rowCount = 0;
                foreach (string catagory in generatedCategories)
                {


                    foreach (ucSkills skillsControl in skillsControls)
                    {
                        if (catagory == skillsControl.skillPanel.PanelTitle)
                        {
                            skillsControl.Width = 360;
                            skillsControl.skillGrid.Width = skillsControl.Width;
                            skillsControl.skillGrid.DataSource = skillsControl.skillTable;
                            skillsControl.skillGrid.Columns[0].Width = skillsControl.skillGrid.Width / skillsControl.skillGrid.Columns.Count;
                            skillsControl.skillGrid.Columns[1].Width = skillsControl.skillGrid.Width / skillsControl.skillGrid.Columns.Count;
                            skillsControl.skillPanel.PanelState = StaffDotNet.CollapsiblePanel.PanelStateOptions.Collapsed;
                            safeTableLayoutAddControl(userControls[i].skillTableLayout, skillsControl);
                            rowCount++;
                        }
                    }
                }
                string serverStatus = this.Api.GetServerStatus().ToString();
                serverStripStatusLabel1.Text = "Server Status: " + serverStatus;
                userControls[i].characterPictureBox.Image = this.Api.DownloadCharacterImage(charactersToShow[i].CharacterID, EveAI.Live.ImageServer.ImageSize.Size128px);
                /// Fills picture box with image
                userControls[i].characterPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                safeUcUpdate (userControls[i]);
                
            }
            safeImageHide(this.imgMainLoad);
           
            
        }

        void btnRefresh_Click(object sender, EventArgs e)
        {
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\EveAI\\Cache", true);
            populateThread = new Thread(Populate_Skills);
            Main_Load(sender, e);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            populateThread.Start();   
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\EveAI\\Cache", true);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
