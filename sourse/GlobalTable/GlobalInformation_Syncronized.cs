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
    public class GlobalInformation_Syncronized
    {
        MainFrame OriginFrame;
        public GlobalInformation_Syncronized(MainFrame OriginFrame)
        {
            this.OriginFrame = OriginFrame;
        }

        public bool AddData(GlobalInformation info)
        {
            if (OriginFrame.GlobalInformation.Add(info))
            {
                var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                int rowNumber = GlobalTable.Rows.Add();
                GlobalTable.Rows[rowNumber].Cells["GlobalOrganizationName"].Value = info.OrganizationName;
                GlobalTable.Rows[rowNumber].Cells["GlobalAdress"].Value = info.Adress;
                GlobalTable.Rows[rowNumber].Cells["GlobalSale"].Value = info.Sale;


                OriginFrame.GlobalInformationTree.Add(OriginFrame.GlobalInformation.FindElemInfo(info));

                return true;

            }
            else {
                OriginFrame.ThrowError("Элемент уже находится в справочнике!");
            }
            return false;
        }

        public bool RemoveData(GlobalInformation info)
        {
            DataGridView GlobalTable;
            if (
                OriginFrame.GlobalInformationTree.Delete(info)
                && OriginFrame.GlobalInformation.Remove(info)
                )
            {
                GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
                for (int rowNumber = 0; rowNumber < GlobalTable.Rows.Count; rowNumber++)
                {
                    if ((string)GlobalTable.Rows[rowNumber].Cells["GlobalOrganizationName"].Value == info.OrganizationName &&
                    (string)GlobalTable.Rows[rowNumber].Cells["GlobalAdress"].Value == info.Adress &&
                    (string)GlobalTable.Rows[rowNumber].Cells["GlobalSale"].Value == info.Sale )
                    {
                        GlobalTable.Rows.Remove(GlobalTable.Rows[rowNumber]);
                    }
                }

                return true;
            }
            return false;
        }

        public void Clear()
        {
            var GlobalTable = OriginFrame.FrameTables.TabPages[0].Controls.OfType<DataGridView>().First();
            while (GlobalTable.Rows.Count != 0)
            {
                GlobalTable.Rows.Remove(GlobalTable.Rows[0]);
            }
            OriginFrame.GlobalInformation.Clear();
            OriginFrame.GlobalInformationTree.Clear();
        }
    }
}
