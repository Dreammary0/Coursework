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
    public class OrgInfo_Syncronized
    {
        MainFrame OriginFrame;
        public OrgInfo_Syncronized(MainFrame OriginFrame)
        {
            this.OriginFrame = OriginFrame;
        }

        public bool RemoveData(LocalInformation info)
        {
            DataGridView UsersTable;
            if (OriginFrame.PlayersInformationHash.Remove(info))
            {
                UsersTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                for (int i = 0; i < UsersTable.Rows.Count; i++)
                {
                    if ((string)UsersTable.Rows[i].Cells["LocalOrganizationName"].Value == info.OrganizationName
                        && (string)UsersTable.Rows[i].Cells["LocalAdress"].Value == info.Adress)
                    {
                        UsersTable.Rows.Remove(UsersTable.Rows[i]);
                    }
                }
                return true;
            }
            else { OriginFrame.ThrowError("Не знаем таких("); } //проверка корректности удаления
            return false;
        }

        public bool AddData(LocalInformation info)
        {
            if (OriginFrame.PlayersInformationHash.Add(info))
            {
                var UsersTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
                int rowNumber = UsersTable.Rows.Add();
                UsersTable.Rows[rowNumber].Cells["LocalOrganizationName"].Value = info.OrganizationName;
                UsersTable.Rows[rowNumber].Cells["LocalAdress"].Value = info.Adress;
                return true;
            }
            else { OriginFrame.ThrowError("Организация хочет остаться уникальной("); } //проверка на уникальность ключа
            return false;
        }

        public void Clear()
        {
            var LocalTable = OriginFrame.FrameTables.TabPages[1].Controls.OfType<DataGridView>().First();
            while (LocalTable.Rows.Count != 0)
            {
                LocalTable.Rows.Remove(LocalTable.Rows[0]);
            }

            OriginFrame.PlayersInformationHash.ClearHashTable();
        }
    }
}
