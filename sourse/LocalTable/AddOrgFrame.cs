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
    public partial class AddOrgFrame : Form
    {

        public MainFrame OriginFrame;
        ChangePlayersTableData action;
        OrgInfo_Syncronized TableAccess;
        public AddOrgFrame(MainFrame OriginFrame, InterfaceCodes code)
        {
            InitializeComponent();

            this.OriginFrame = OriginFrame;
            TableAccess = new OrgInfo_Syncronized(OriginFrame);
            switch(code)
            {
                case InterfaceCodes.Add:
                    action = new AddInformation(this);
                    break;
                case InterfaceCodes.Remove:
                    action = new RemoveInformation(this, OriginFrame);
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            action.ChangeDataFromInterface();
        }



        abstract class ChangePlayersTableData
        {
            public abstract void ChangeDataFromInterface();
        }
          
        class AddInformation : ChangePlayersTableData //класс добавления на выбор
        {
            AddOrgFrame CurFrame;
            public AddInformation(AddOrgFrame CurFrame)
            {
                this.CurFrame = CurFrame;
                this.CurFrame.MainLabel.Text = "Добавить новую запись";
            }

            public override void ChangeDataFromInterface()
            {
                if (CurFrame.OrgTextBox.Text == ""
                    || CurFrame.AdressTextBox.Text == "")
                {
                 
                    return;
                }
                LocalInformation info = new LocalInformation();
                info.OrganizationName = CurFrame.OrgTextBox.Text;
                info.Adress = CurFrame.AdressTextBox.Text;

                CurFrame.TableAccess.AddData(info);
            }
        }

        class RemoveInformation : ChangePlayersTableData //класс удаления на выбор
        {
            AddOrgFrame CurFrame;
            MainFrame OriginFrame;
            public RemoveInformation(AddOrgFrame CurFrame, MainFrame OriginFrame)
            {
                this.CurFrame = CurFrame;
                this.OriginFrame = OriginFrame;
                this.CurFrame.MainLabel.Text = "Удалить запись";
                this.CurFrame.OrgDataChangesButton.Text = "Удалить";
            }

            
            //
            public override void ChangeDataFromInterface() 
            {
                LocalInformation info = new LocalInformation();
                info.OrganizationName = CurFrame.OrgTextBox.Text;
                info.Adress = CurFrame.AdressTextBox.Text; //фрейм, в котором находишься

                bool Deleted = this.CurFrame.TableAccess.RemoveData(info); 

                if (Deleted)
                {
                    // Изменение глобальной таблицы
                    var UsersTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                    for (int i = 0; i < UsersTable.Rows.Count; i++)
                    {


                        if ((string)UsersTable.Rows[i].Cells["GlobalOrganizationName"].Value == info.OrganizationName
                            && (string)UsersTable.Rows[i].Cells["GlobalAdress"].Value == info.Adress)
                        {
                            GlobalInformation Instance = new GlobalInformation
                            {
                                OrganizationName = (string)UsersTable.Rows[i].Cells["GlobalOrganizationName"].Value,
                                Adress = (string)UsersTable.Rows[i].Cells["GlobalAdress"].Value,
                                Sale = (string)UsersTable.Rows[i].Cells["GlobalSale"].Value,
                            };


                            GlobalInformation_Syncronized GI_Access = new GlobalInformation_Syncronized(OriginFrame);
                            GI_Access.RemoveData(Instance);
                        }
                    }
                }
            }
        }

        private void AdressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void MainLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddOrgFrame_Load(object sender, EventArgs e)
        {

        }
         
        private void OrgTextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void OrgAddbuttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    
}
