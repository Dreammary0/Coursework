using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_CourseWork
{
    public class BTree //класс Бинарное дерево
    {


 
        public MainFrame OriginFrame; //синхранизация с главным окном

        public BTree(MainFrame OriginFrame) { this.OriginFrame = OriginFrame; } //синхранизация с основным окнос


        //элемент дерева
        public class TreeNode
        {
            public TreeNode Left = null;
            public TreeNode Right = null;
            public GlobalInformation info;
        }
        //голова
        public TreeNode Head = null;

        //вывод дерева на экран
        public string PrGlobalInformationTree()
        {
            OriginFrame.AddLog("Вывод дерева(названий)");
            string result = "";
            prGlobalInformation_Tree_Hidden(Head, 0, ref result);
            return result;
        }

        //вывод дерева 
        private void prGlobalInformation_Tree_Hidden(TreeNode p, int level, ref string result)
        {
            if (p != null)
            {
                prGlobalInformation_Tree_Hidden(p.Right, level + 1, ref result);
                for (int i = 0; i < level; i++) result += "   ";
                result += p.info.OrganizationName + "\n";
                prGlobalInformation_Tree_Hidden(p.Left, level + 1, ref result);
            }
        }

        public List<GlobalInformation> FindAll(string OrganizationName)
        {
            List<GlobalInformation> res = new List<GlobalInformation>();
            OriginFrame.AddLog("Поиск в дереве начался:");
            int comp = 0;
            var mover = Head;
            while (mover != null)
            {
                comp++;
                if (OrganizationName == mover.info.OrganizationName)
                {
                    OriginFrame.AddLog("Элемент найден, адрес - " + mover.info.OrganizationName);
                    OriginFrame.AddLog("Кол-во сравнений: " + comp);
                    res.Add(mover.info);
                }
                if (string.Compare(OrganizationName, mover.info.OrganizationName) >= 0)
                {
                    mover = mover.Right;
                }
                else
                {
                    mover = mover.Left;
                }
            }
            OriginFrame.AddLog("Вывод дерева(названий)");

            return res;
        }

        //добавление 
        public bool Add(GlobalInformation info)
        {
            var NewData = new TreeNode();
            NewData.info = (GlobalInformation)info.Clone();

            if (Head == null)
            {
                Head = NewData;
                OriginFrame.AddLog(PrGlobalInformationTree());
                return true;
            }

            TreeNode mover = Head;
            while (true)
            {
                if (string.Compare(info.OrganizationName,mover.info.OrganizationName) >= 0)
                {
                    if (mover.Right == null)
                    {
                        mover.Right = NewData;
                        OriginFrame.AddLog(PrGlobalInformationTree());
                        return true;
                    }
                    else
                    {
                        mover = mover.Right;
                    }
                }
                else
                {
                    if (mover.Left == null)
                    {
                        mover.Left = NewData;
                        OriginFrame.AddLog(PrGlobalInformationTree());
                        return true;
                    }
                    else
                    {
                        mover = mover.Left;
                    }
                }
            }
        }

        public void Clear()
        {
            Head = null;
            GC.Collect();
        }

        //поиск родителей
        public TreeNode GetParent(TreeNode node)
        {
            TreeNode mover = Head;
            while (mover != null)
            {
                if (string.Compare(node.info.OrganizationName,mover.info.OrganizationName) >= 0)
                {
                    if (mover.Right == node)
                    {
                        return mover;
                    }
                    else
                    {
                        mover = mover.Right;
                    }
                }
                else
                {
                    if (mover.Left == node)
                    {
                        return mover;
                    }
                    else
                    {
                        mover = mover.Left;
                    }
                }
            }
            return null;
        }



        private void DeleteSubFunction(TreeNode Node)
        {
            if (Node == Head)
            {
                if (Node.Left != null)
                    Head = Node.Left;
                else if (Node.Right != null)
                    Head = Node.Right;
                else
                    Head = null;

                return;
            }


            var Parent = GetParent(Node);
            if (Parent == null) return;

            if (Parent.Left == Node)
            {
                if (Node.Left != null)
                {
                    Parent.Left = Node.Left;
                }
                else if (Node.Right != null)
                {
                    Parent.Left = Node.Right;
                }
                else
                {
                    Parent.Left = null;
                }
            }
            else
            {
                if (Node.Left != null)
                {
                    Parent.Right = Node.Left;
                }
                else if (Node.Right != null)
                {
                    Parent.Right = Node.Right;
                }
                else
                {
                    Parent.Right = null;
                }
            }
            GC.Collect();
        }

        public TreeNode FindByOrganizationName(string OrganizationName)
        {
            OriginFrame.AddLog("Поиск в дереве начался:");
            int comp = 0;
            var mover = Head;
            while (mover != null)
            {
                comp++;
                if (OrganizationName == mover.info.OrganizationName)
                {
                    OriginFrame.AddLog("Элемент найден, акция - " + mover.info.Sale);
                    OriginFrame.AddLog("Кол-во сравнений: " + comp);
                    return mover;
                }
                else if (string.Compare(OrganizationName, mover.info.OrganizationName) > 0)
                {
                    mover = mover.Right;
                }
                else
                {
                    mover = mover.Left;
                }
            }
            OriginFrame.AddLog("Вывод дерева(названий)");

            return null;
        }

        public TreeNode Find(GlobalInformation info)
        {
            OriginFrame.AddLog("Поиск в дереве начался:");
            int comp = 0;
            var mover = Head;
            while (mover != null)
            {
                comp++;
                if (info.OrganizationName == mover.info.OrganizationName)
                {
                    OriginFrame.AddLog("Элемент найден, адрес - " + mover.info.OrganizationName);
                    OriginFrame.AddLog("Кол-во сравнений: " + comp);
                    OriginFrame.AddLog(PrGlobalInformationTree());
                    return mover;
                }
                else if (string.Compare(info.OrganizationName,mover.info.OrganizationName) > 0)
                {
                    mover = mover.Right;
                }
                else
                {
                    mover = mover.Left;
                }
            }
            OriginFrame.AddLog("Вывод дерева(названий)");
            OriginFrame.AddLog(PrGlobalInformationTree());
            return null;
        }

        //удаление элемента (несколько вариантов)
        public bool Delete(GlobalInformation info)
        {  

            var NodeToDelete = Find(info);
            if (NodeToDelete == null) return false;

            if (NodeToDelete.Left != null && NodeToDelete.Right != null)
            {
                var MaxLeftElem = NodeToDelete.Left;
                while (MaxLeftElem.Right != null)
                {
                    MaxLeftElem = MaxLeftElem.Right;
                }
                var InfoToChange = MaxLeftElem.info;
                DeleteSubFunction(MaxLeftElem);
                NodeToDelete.info = InfoToChange;
            }
            else
            {
                DeleteSubFunction(NodeToDelete);
            }
            OriginFrame.AddLog(PrGlobalInformationTree());
            return true;
        }
    }
}
