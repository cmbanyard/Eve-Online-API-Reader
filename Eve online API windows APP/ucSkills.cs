using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ucSkills : UserControl
    {
        public DataTable skillTable = new DataTable();
        public ucSkills()
        {
            InitializeComponent();

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "Level";
            skillTable.Columns.Add("Skill Name", typeof(string));
            skillTable.Columns.Add("Level", typeof(Image));


        }

        private void skillPanel_StateChanged()
        {
            if (skillPanel.PanelState == StaffDotNet.CollapsiblePanel.PanelStateOptions.Collapsed )
            {
                this.Height = 20;
            }
            else if (skillPanel.PanelState == StaffDotNet.CollapsiblePanel.PanelStateOptions.Expanded)
            {
                this.Height = (skillGrid.Rows.Count *  skillGrid.Rows[0].Height) + 45;
                this.skillGrid.Height = skillGrid.Rows.Count * skillGrid.Rows[0].Height + skillGrid.ColumnHeadersHeight;

            }
        }

        private void skillGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skillGrid_SelectionChanged(object sender, EventArgs e)
        {
            skillGrid.ClearSelection();
        }

    }
}
