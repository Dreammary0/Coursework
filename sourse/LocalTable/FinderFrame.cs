using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_CourseWork
{
    public partial class FinderFrame : Form
    {
        private MainFrame OriginFrame;
        public FinderFrame(MainFrame OriginFrame)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
        }

        public void DisableFilter()
        {
            var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
            while (LocalTable.Rows.Count != 0)
            {
                LocalTable.Rows.Remove(LocalTable.Rows[0]);
            }

            var HashTable = OriginFrame.PlayersInformationHash;
            for (int i = 0; i < HashTable.Size; i++)
            {
                var mover = HashTable.Table[i].Head;
                while (mover != null)
                {

                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["LocalOrganizationName"].Value = mover.Info.OrganizationName;
                    LocalTable.Rows[rowNumber].Cells["LocalAdress"].Value = mover.Info.Adress;


                    mover = mover.Next;
                }
                
            }
        }

        private void FilterDataTypeButton_Click(object sender, EventArgs e)
        {
            switch (FindComboBox.Text)
            {
                case "Поиск по названию организации":
                    OrgNameFindFrame LoginFilterPlayerDialog = new OrgNameFindFrame(OriginFrame, InterfaceCodes.FilterLocalTable);
                    LoginFilterPlayerDialog.ShowDialog(OriginFrame);
                    LoginFilterPlayerDialog.Dispose();
                    break;
                case "Поиск по адресу":
                    AdressFIndFrame AgeFilterPlayerDialog = new AdressFIndFrame(OriginFrame, InterfaceCodes.FilterLocalTable);
                    AgeFilterPlayerDialog.ShowDialog(OriginFrame);
                    AgeFilterPlayerDialog.Dispose();

                    Close();
                    break;
                case "Сбросить поисковик":
                    DisableFilter();

                    Close();
                    break;
            }
        }

        private void Finderbutton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FinderFrame_Frame_Load(object sender, EventArgs e)
        {

        }
    }
}
