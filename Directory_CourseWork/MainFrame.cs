using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_CourseWork
{
    public enum InterfaceCodes
    {
        Add = 0,
        Remove = 1,
        FilterGlobalTable = 3,
        FilterLocalTable = 4,
    }

    public partial class MainFrame : Form
    {

        // Объявление хэша + список общей таблицы
        public GlobalDoubleLinkedList GlobalInformation = new GlobalDoubleLinkedList();
        public LocalInformationHashTable PlayersInformationHash;


        // Объявление дерева поиска
        public BTree GlobalInformationTree;
        public BTree PlayerInformationTree;



        public TabControl FrameTables;
        public MainFrame()
        {
            InitializeComponent();
            FrameTables = TablesControl;
            PlayersInformationHash = new LocalInformationHashTable(this);
            GlobalInformationTree = new BTree(this);
        }


        //===========================================
        //============== Дебаг-меню =================
        //===========================================

        string Log = "";
        DebugFrame Debug;
        public void AddLog(string log)
        {
            Log += log + "\n";
            if (Debug != null)
            {
                Debug.AddLog(log);
            }
        }

        private void открытьДебагменюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug = new DebugFrame(Log);
            Debug.Show();
        }

        //===========================================
        //============ Сохранение таблицы ===========
        //===========================================

        public void SaveInformation()
        {
            //работа с файлом
            Stream SaveStream; //класс для передачи данных
            SaveFileDialog SaveMapDialog = new SaveFileDialog(); //окно сохраниния на пк

            SaveMapDialog.Filter = "Table files (*.tbl)|*.tbl"; //формат файла
            SaveMapDialog.FilterIndex = 2;
            SaveMapDialog.RestoreDirectory = true;

            if (SaveMapDialog.ShowDialog() == DialogResult.OK) //если пользователь сохраняет
            {
                if ((SaveStream = SaveMapDialog.OpenFile()) != null)   //открывается файл, куда сохранить
                {
                    string StringData = "";  //одна строка
                    GlobalDoubleLinkedList.ListElem mover = GlobalInformation.Head;
                    while (mover != null)
                    {
                        GlobalInformation info = mover.Info;

                        StringData += info.OrganizationName + " " + info.Adress + " " + info.Sale + "\n";

                        mover = mover.Next;
                    }
                    StringData += "\n";


                    for (int i = 0; i < PlayersInformationHash.Size; i++)
                    {
                        var mover2 = PlayersInformationHash.Table[i].Head;
                        while (mover2 != null)
                        {
                            StringData += mover2.Info.OrganizationName + " " + mover2.Info.Adress + "\n";

                            mover2 = mover2.Next;
                        }

                    }


                    byte[] Data = System.Text.Encoding.Default.GetBytes(StringData);  //закодировать в файл
                    SaveStream.Write(Data, 0, Data.Length);
                    SaveStream.Close();  //закрыть файл
                }
            }
        }


        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveInformation();
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInformation();
        }

        //===========================================
        //============== Загрузка таблицы ===========
        //===========================================

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrgInfo_Syncronized PI_Access = new OrgInfo_Syncronized(this);
            GlobalInformation_Syncronized GI_Access = new GlobalInformation_Syncronized(this);
            PI_Access.Clear();
            GI_Access.Clear();

            Stream LoadStream;  //данные
            OpenFileDialog loadMapDialog = new OpenFileDialog();  //диалог для загрузки файла

            loadMapDialog.Filter = "Table files (*.tbl)|*.tbl"; //формат
            loadMapDialog.FilterIndex = 2;
            loadMapDialog.RestoreDirectory = true;

            if (loadMapDialog.ShowDialog() == DialogResult.OK) //нажали загрузить
            {
                if ((LoadStream = loadMapDialog.OpenFile()) != null)
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[LoadStream.Length];
                    // считываем данные
                    LoadStream.Read(array, 0, array.Length);
                    // декодируем байты в строку
                    string textFromFile = System.Text.Encoding.Default.GetString(array);



                    string[] Rows = textFromFile.Split('\n'); //просматриваем строку и разбивает ее на подстроки
                    int CurTable = 0;
                    for (int ri = 0; ri < Rows.Length - 1; ri++) //разбить на строки
                    {
                        if (Rows[ri] == "" || Rows[ri] == "/r")
                            CurTable++;
                        else
                        {
                            string[] Infos = Rows[ri].Split(' ');
                            switch (CurTable)
                            {
                                case 0:
                                    GlobalInformation info = new GlobalInformation();
                                    info.OrganizationName = Infos[0];
                                    info.Adress = Infos[1];
                                    info.Sale = Infos[2];

                                    GI_Access.AddData(info);
                                    break;
                                case 1:
                                    LocalInformation info2 = new LocalInformation();
                                    info2.OrganizationName = Infos[0];
                                    info2.Adress = Infos[1];

                                    PI_Access.AddData(info2);
                                    break;
                            }
                        }
                    }

                    LoadStream.Close();  //закрыть файл
                }
            }
        }

        //===========================================
        //========== Глобальная таблица =============
        //===============(хэндлеры)==================

        private void AddInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_AddFrame AddInformationDialog = new GlobalTable_AddFrame(this, InterfaceCodes.Add);
            AddInformationDialog.ShowDialog(this);
            AddInformationDialog.Dispose();
        }

        private void MainTable_DeleteInformation_Click(object sender, EventArgs e)
        {
            GlobalTable_AddFrame RemoveInformationDialog = new GlobalTable_AddFrame(this, InterfaceCodes.Remove);
            RemoveInformationDialog.ShowDialog(this);
            RemoveInformationDialog.Dispose();
        }

        private void MainTable_SearchButton_Click(object sender, EventArgs e)
        {
            var FilterInformationDialog = new GlobalTable_FindFrame(this);
            FilterInformationDialog.ShowDialog(this);
            FilterInformationDialog.Dispose();
        }

        //===========================================
        //========== Таблица игроков ================
        //===============(хэндлеры)==================
        private void PlayersTable_AddInformation_Click(object sender, EventArgs e)
        {
            AddOrgFrame testDialog = new AddOrgFrame(this, InterfaceCodes.Add);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void PlayersTable_RemoveInformation_Click(object sender, EventArgs e)
        {
            AddOrgFrame testDialog = new AddOrgFrame(this, InterfaceCodes.Remove);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void PlayersTable_FilterInformation_Click(object sender, EventArgs e)
        {
            FinderFrame testDialog = new FinderFrame(this);
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }

        private void MainTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
