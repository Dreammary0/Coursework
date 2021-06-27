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
    public partial class GlobalTable_FindFrame : Form
    {
        private MainFrame OriginFrame;
        public GlobalTable_FindFrame(MainFrame OriginFrame)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
        }

        public void DisableFilter()
        {
            // Очищаем таблицу
            var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
            while(GlobalTable.Rows.Count != 0)
            {
                GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
            }

            var GlobalTableList = OriginFrame.GlobalInformation;
            var mover = GlobalTableList.Head;
            while(mover != null)
            {
                int rowNumber = GlobalTable.Rows.Add();
                GlobalTable.Rows[rowNumber].Cells["GlobalOrganizationName"].Value = mover.Info.OrganizationName;
                GlobalTable.Rows[rowNumber].Cells["GlobalAdress"].Value = mover.Info.Adress;
                GlobalTable.Rows[rowNumber].Cells["GlobalSale"].Value = mover.Info.Sale;

                mover = mover.Next;
            }
        }

        private void FilterDataTypeButton_Click(object sender, EventArgs e)
        {
            switch (FinderComboBox.Text)
            {
                case "Поиск по названию организации":
                    OrgNameFindFrame LoginFilterPlayerDialog = new OrgNameFindFrame(OriginFrame, InterfaceCodes.FilterGlobalTable);
                    LoginFilterPlayerDialog.ShowDialog(OriginFrame);
                    LoginFilterPlayerDialog.Dispose();
                    break;
                case "Поиск по адресу":
                    AdressFIndFrame AgeFilterPlayerDialog = new AdressFIndFrame(OriginFrame, InterfaceCodes.FilterGlobalTable);
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
   

        private void FinderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GlobalTable_FindFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
