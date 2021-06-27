using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_CourseWork
{
    public class BTree //класс Бинарное дерево
    {
        public class TreeElem //элемент дерева
        {
            public TreeElem left = null; // Левый потомок
            public TreeElem right = null; // Правый потомок
            public GlobalInformation info; // Ключ узла (3 поля)
        };

        public TreeElem Head = null; // Корень дерева
        public MainFrame OriginFrame; //синхранизация с главным окном

       // private BTree() { }
        public BTree(MainFrame OriginFrame) { this.OriginFrame = OriginFrame; } //синхранизация с основным окнос

        // Рекурсивный вывод дерева в окно
        // Формальные и входные параметры - нет
        // Выходные данные - значения элементов дерева
        public string PrintTree() 
        {
            OriginFrame.AddLog("Вывод дерева(адреса)"); //в сообщение в отладку
            string result = "";
            print_Tree_Hidden(Head, 0, ref result);
            return result;
        }

        //Рекурсивынй вывод дерева 
        // Формальные и входные параметры - элемент p, переменная уровня level, result
        // Выходные данные - значения элементов дерева

        private void print_Tree_Hidden(TreeElem p, int level, ref string result)
        {
            if (p != null) //бегунок
            {
                print_Tree_Hidden(p.right, level + 1, ref result);
                for (int i = 0; i < level; i++) result += "   ";
                result += p.info.Adress + "\n";
                print_Tree_Hidden(p.left, level + 1, ref result);
            }
        }

        // Прямой обход(кто первый тот и выводится)
        // Формальные и входные параметры - корень дерева
        // Выходные данные - значения элементов дерева
        public void print_NLR(TreeElem Head)
        {
            Console.Write(Head.info.Adress + " ");
            if (Head.left != null) print_NLR(Head.left);
            if (Head.right != null) print_NLR(Head.right);
        }

        // Поиск родителя элемента-наследника(если таковой есть)
        // Формальные и входные параметры - корень дерева, элемент child
        // Выходные данные - значения элементов дерева
        public TreeElem GetParent(TreeElem child)
        {
            if (child == null) return null;
            TreeElem mover = Head; 
            if (mover == child) return null;

            while (mover.left != child && mover.right != child)
            { 
                if (string.Compare(mover.info.Adress, child.info.Adress) >= 0) //приобразование для сравнения стринга
                    mover = mover.right;
                else mover = mover.left;
            }

            return mover;
        }


        // Очистка дерева от элементов
        // Формальные и входные параметры - дерево, корень дерева
        // Выходные данные - нет
        public void ClearTree()
        {
            Head = null;
            GC.Collect();
        }


        // Поиск элемента в дереве по адресу
        // Формальные и входные параметры - корень дерева, ключ элемента который нужно найти(пара название\адрес
        // Выходные данные - нужный элемент либо null, если элемента нет в дереве
        public TreeElem FindElem(TreeElem elem, GlobalInformation info)
        {
            if (elem == null) return null;

            if (elem.info.Adress == info.Adress && elem.info.OrganizationName == info.OrganizationName) return elem;

            TreeElem ElementToReturn = FindElem(elem.left, info); //рекурсивно слева
            if (ElementToReturn != null) return ElementToReturn;

            ElementToReturn = FindElem(elem.right, info); //рекурсивно справа
            if (ElementToReturn != null) return ElementToReturn;

            return null;
        }

        // Поиск элемента в дереве по адресу
        // Формальные и входные параметры - корень дерева, ключ элемента который нужно найти(адрес)
        // Выходные данные - нужный элемент либо null, если элемента нет в дереве
        public TreeElem FindElemByAdress(TreeElem elem, string Adress)
        {
            if (elem == null) return null;

            if (elem.info.Adress == Adress) return elem;

            TreeElem ElementToReturn = FindElemByAdress(elem.left, Adress);
            if (ElementToReturn != null) return ElementToReturn;

            ElementToReturn = FindElemByAdress(elem.right, Adress);
            if (ElementToReturn != null) return ElementToReturn;

            return null;
        }

        // Поиск элемента в дереве по названию
        // Формальные и входные параметры - корень дерева, ключ элемента который нужно найти(название)
        // Выходные данные - нужный элемент либо null, если элемента нет в древе
        public TreeElem FindElemByOrganizationName(TreeElem elem, string OrganizationName)
        {
            if (elem == null) return null;

            if (elem.info.OrganizationName == OrganizationName) return elem;

            TreeElem ElementToReturn = FindElemByOrganizationName(elem.left, OrganizationName);
            if (ElementToReturn != null) return ElementToReturn;

            ElementToReturn = FindElemByOrganizationName(elem.right, OrganizationName);
            if (ElementToReturn != null) return ElementToReturn;

            return null;
        }

        // Находит максимальный элемент в древе/поддереве
        // Формальные и входные параметры - корень древа
        // Выходные данные - максимальный элемент древа
        public TreeElem FindMaxElem(TreeElem elem)
        {
            if (elem == null) return null;

            while (elem.right != null)
            {
                elem = elem.right;
            }
            return elem;
        }


        // Находит минимальный элемент в древе/поддереве.
        // Формальные и входные параметры - корень древа
        // Выходные данные - минимальный элемент древа
        public TreeElem FindMinElem(TreeElem elem)
        {
            if (elem == null) return null;

            while (elem.left != null)
            {
                elem = elem.left;
            }
            return elem;
        }


        // Добавляет новый элемент в древо
        // Формальные и входные параметры - корень древа, ключ нового элемента
        // Выходные данные - нет
        public bool NewElem(GlobalInformation info)
        {
            if (FindElemByOrganizationName(Head, info.OrganizationName) != null)  
            {
                return false;
            }

            TreeElem newelem = new TreeElem();
            newelem.info = info;
            if (Head == null)
            {
                Head = newelem;
            }
            else
            {
                TreeElem mover = Head;
                string newInfo = newelem.info.Adress;
                while (true)
                {
                    if (string.Compare(mover.info.Adress, newInfo) >= 0) //сравнение стринга
                    {
                        if (mover.right == null)
                        {
                            mover.right = newelem;
                            break;
                        }
                        mover = mover.right;
                    }
                    else
                    {
                        if (mover.left == null)
                        {
                            mover.left = newelem;
                            break;
                        }
                        mover = mover.left;
                    }
                }
            }
            OriginFrame.AddLog("[BTree] Добавлен новый элемент в дерево"); //отладчик
            OriginFrame.AddLog(PrintTree());
            return true;
        }


        // Удаляет элемент у которого нет детей, либо ребенок только один. Меняет корректно связи.
        // Вызывать функцию отдельно при удалении НЕ НАДО. Она сама вызывается в основной функции удаления
        // Формальные и входные параметры - корень древа, удаляемый элемент.
        // Выходные данные - нет
        private void DeleteElemSubfunc(TreeElem elem)
        {
            TreeElem Parent = GetParent(elem);
            if (Parent != null)
            {
                if (elem.left == null && elem.right == null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = null;
                    }
                    else
                    {
                        Parent.right = null;
                    }
                }
                else if (elem.right != null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = elem.right;
                    }
                    else
                    {
                        Parent.right = elem.right;
                    }
                }
                else if (elem.left != null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = elem.left;
                    }
                    else
                    {
                        Parent.right = elem.left;
                    }
                }
            }
            else
            {
                Head = null;
            }
            elem = null;


        }

        // Основная функция удаления элемента из дерева. Удаляет элемент(замена на max слева)
        // Формальные и входные параметры - древо, ключ удаляемого элемента
        // Выходные данные - нет
        public bool DeleteElem(GlobalInformation info)
        {
            TreeElem ElementToDelete = FindElem(Head, info);
            if (ElementToDelete == null) return false;

            TreeElem child = null;
            TreeElem Parent = GetParent(ElementToDelete); //поиск родителей эл-та
            if (ElementToDelete.left == null || ElementToDelete.right == null)
            {
                if (ElementToDelete.left != null) child = ElementToDelete.left;
                else if (ElementToDelete.right != null) child = ElementToDelete.right;

                DeleteElemSubfunc(ElementToDelete);
            }
            else
            {
                TreeElem max = FindMaxElem(ElementToDelete.left);

                if (max.left != null) child = max.left;
                else if (max.right != null) child = max.right;

                Parent = GetParent(max);
                DeleteElemSubfunc(max);
                ElementToDelete.info = max.info;
            }
            OriginFrame.AddLog("[BTree] Был удален элемент из дерева");
            OriginFrame.AddLog(PrintTree());
            return true;
        }

    }
}
