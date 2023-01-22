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
    public partial class AdressFIndFrame : Form
    {
        private MainFrame OriginFrame;
        private FilterData filterHandler;
        public bool IsFilterOn;
        public AdressFIndFrame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
            switch(code)
            {
                case InterfaceCodes.FilterGlobalTable:
                    filterHandler = new FilterGlobalData(this);
                    break;
                case InterfaceCodes.FilterLocalTable:
                    filterHandler = new FilterLocalData(this);
                    break;
            }
        }

  

        abstract class FilterData
        {
            public abstract void FilterDataFromInterface(MainFrame OriginFrame, string Adress);
        }

        class FilterGlobalData : FilterData
        {
            AdressFIndFrame CurFrame;
            public FilterGlobalData(AdressFIndFrame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, string Adress)
            {
                // Очищаем таблицу
                var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                while(GlobalTable.Rows.Count != 0)
                {
                    GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
                }

                var ElementsFound = OriginFrame.GlobalInformationTree.FindAll(Adress);
                for (int i = 0; i < ElementsFound.Count; i++)
                {
                    int rowNumber = GlobalTable.Rows.Add();

                    GlobalTable.Rows[rowNumber].Cells["GlobalOrganizationName"].Value = ElementsFound[i].OrganizationName;
                    GlobalTable.Rows[rowNumber].Cells["GlobalAdress"].Value = ElementsFound[i].Adress;
                    GlobalTable.Rows[rowNumber].Cells["GlobalSale"].Value = ElementsFound[i].Sale;
                }
            }
        }

        class FilterLocalData : FilterData
        {
            AdressFIndFrame CurFrame;
            public FilterLocalData(AdressFIndFrame CurFrame)
            {
                this.CurFrame = CurFrame;
            }

            public override void FilterDataFromInterface(MainFrame OriginFrame, string Adress)
            {
                // Очищаем таблицу
                var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                while (LocalTable.Rows.Count != 0)
                {
                    LocalTable.Rows.Remove(LocalTable.Rows[0]);
                }

                var FilteredElements = OriginFrame.PlayersInformationHash.FindByAdress(Adress);
                for (int i = 0; i < FilteredElements.Count; i++)
                {
                    int rowNumber = LocalTable.Rows.Add();
                    LocalTable.Rows[rowNumber].Cells["LocalOrganizationName"].Value = FilteredElements[i].OrganizationName;
                    LocalTable.Rows[rowNumber].Cells["LocalAdress"].Value = FilteredElements[i].Adress;
                }
            
            }
        }

        private void buttonFindAdress_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdressFindButton_Click(object sender, EventArgs e)
        {
            filterHandler.FilterDataFromInterface(OriginFrame, textBox1.Text);

        }

        private void AdressFIndFrame_Load(object sender, EventArgs e)
        {

        }

        private void labelFindAdress_Click(object sender, EventArgs e)
        {

        }
    }
}
