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
    public partial class OrgNameFindFrame : Form
    {
        private MainFrame OriginFrame;
        private FilterData filterHandler;
        public bool IsFilterOn;
        public OrgNameFindFrame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
            switch(code)
            {
                case InterfaceCodes.FilterLocalTable:
                    filterHandler = new FilterLocalData(this);
                    break;
            }
        }

      

        abstract class FilterData
        {
            public abstract void FilterDataFromInterface(MainFrame OriginFrame, string login);
        }

       

        class FilterLocalData : FilterData
        {
            OrgNameFindFrame CurFrame;
            public FilterLocalData(OrgNameFindFrame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, string login)
            {
                // Очищаем таблицу
                var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                while (LocalTable.Rows.Count != 0)
                {
                    LocalTable.Rows.Remove(LocalTable.Rows[0]);
                }

                var Element = OriginFrame.PlayersInformationHash.Find(new LocalInformation { OrganizationName = login });
                if (Element != null)
                {
                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["LocalOrganizationName"].Value = Element.OrganizationName;
                    LocalTable.Rows[rowNumber].Cells["LocalAdress"].Value = Element.Adress;
                }
            }
        }



        private void OrgNameButton_Click(object sender, EventArgs e)
        {
            filterHandler.FilterDataFromInterface(OriginFrame, OrgNameTextBox.Text);
        }

        private void OrgNamebutton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilterLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrgNameFindFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
