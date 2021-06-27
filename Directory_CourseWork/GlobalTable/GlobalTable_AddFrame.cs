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
    public partial class GlobalTable_AddFrame : Form
    {
        public MainFrame OriginFrame;
        ChangeGlobalTableData action;
        GlobalInformation_Syncronized GI_Access;
        public GlobalTable_AddFrame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();
            this.OriginFrame = OriginFrame;
            GI_Access = new GlobalInformation_Syncronized(OriginFrame);
            switch (code)
            {
                case InterfaceCodes.Add:
                    action = new AddInformation(this);
                    break;
                case InterfaceCodes.Remove:
                    action = new RemoveInformation(this);
                    break;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            action.ChangeDataFromInterface(OriginFrame);
        }

        abstract class ChangeGlobalTableData
        {
            public abstract void ChangeDataFromInterface(MainFrame OriginFrame);
        }

        class AddInformation : ChangeGlobalTableData
        {
            GlobalTable_AddFrame CurFrame;
            public AddInformation(GlobalTable_AddFrame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Добавить новую запись";
            }

            public override void ChangeDataFromInterface(MainFrame OriginFrame)
            {
                if (CurFrame.OrgNameComboBox.Text == "" 
                    || CurFrame.AdressComboBox.Text == "" 
                    || CurFrame.SaleComboTextBox.Text == "") return;

                var info = new GlobalInformation();
                info.OrganizationName = CurFrame.OrgNameComboBox.Text;
                info.Adress = CurFrame.AdressComboBox.Text;
                info.Sale = CurFrame.SaleComboTextBox.Text;


                var Added = CurFrame.GI_Access.AddData(info);

                if (Added)
                {
                    // Проверка для UserTable, есть ли у нас игрок с таким логином и возрастом
                    var PotentialNewPlayerInformation = new LocalInformation
                    {
                        OrganizationName = info.OrganizationName,
                        Adress = info.Adress
                    };

                    var ExistingInfo = OriginFrame.PlayersInformationHash.Find(PotentialNewPlayerInformation);
                    if (ExistingInfo == null)
                    {
                        OrgInfo_Syncronized PI_Access = new OrgInfo_Syncronized(OriginFrame);
                        PI_Access.AddData(PotentialNewPlayerInformation);
                    }
                    else
                    {
                        if (PotentialNewPlayerInformation.Adress != ExistingInfo.Adress)
                        {
                            OrgInfo_Syncronized PI_Access = new OrgInfo_Syncronized(OriginFrame);
                            PI_Access.RemoveData(ExistingInfo);
                            PI_Access.AddData(PotentialNewPlayerInformation);
                        }
                    }
                }
            }
        }

        class RemoveInformation : ChangeGlobalTableData
        {
            GlobalTable_AddFrame CurFrame;
            public RemoveInformation(GlobalTable_AddFrame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Удалить запись";
                this.CurFrame.ChangeButton.Text = "Удалить";
            }

            public override void ChangeDataFromInterface(MainFrame OriginFrame)
            {
                var info = new GlobalInformation();
                info.OrganizationName = CurFrame.OrgNameComboBox.Text;
                info.Adress = CurFrame.AdressComboBox.Text;
                info.Sale = CurFrame.SaleComboTextBox.Text;

                CurFrame.GI_Access.RemoveData(info);
            }
        }

        private void GlobalTable_AddFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
