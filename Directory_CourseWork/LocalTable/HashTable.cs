using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_CourseWork
{


    public class LocalInformationHashTable
    {
        public class TwoLinkedList
        {
            public ListElem Head = null;
            public ListElem Tail = null;

            // Иниц. элементов списка
            public class ListElem
            {
                public ListElem Prev { get; set; }
                public LocalInformation Info { get; set; }
                public ListElem Next { get; set; }
            };

            // Конструктор
            public TwoLinkedList() { }

            // Очистка списка
            public void Clear()
            {
                if (this.Head == null) return;

                this.Head = null;
                this.Tail = null;
                GC.Collect();
            }

            // Проверка на пустоту
            public bool IsEmpty()
            {
                return this.Head == null && this.Tail == null;
            }

            // Добавление элемента по убыванию
            public bool Add(LocalInformation info)
            {
                if (this.FindElemInfo(info.OrganizationName) != null) return false;

                var Elem = new ListElem();
                Elem.Info = (LocalInformation)info.Clone();

                if (this.Head == null)
                {
                    this.Head = Elem;
                    this.Tail = Elem;
                    return true;
                }

                this.Tail.Next = Elem;
                this.Tail = this.Tail.Next;

                return true;
            }

            public bool Remove(LocalInformation info)
            {
                var elem = this.FindElem(info);
                if (elem != null)
                {
                    if (elem.Prev != null)
                    {
                        if (elem.Next != null)
                            elem.Prev.Next = elem.Next;
                        else
                        {
                            elem.Prev.Next = null;
                            this.Tail = elem.Prev;
                        }
                    }
                    else
                    {
                        this.Head = null;
                    }

                    if (elem.Next != null)
                    {
                        if (elem.Prev != null)
                            elem.Next.Prev = elem.Prev;
                        else
                        {
                            elem.Next.Prev = null;
                            this.Head = elem.Next;
                        }
                    }
                    else
                    {
                        this.Tail = null;
                    }
                    GC.Collect();
                    return true;
                }
                return false;
            }

            // Поиск по логину
            public LocalInformation FindElemInfo(string OrganizationName)
            {
                ListElem mover = this.Head;
                while (mover != null)
                {
                    if (mover.Info.OrganizationName == OrganizationName) return mover.Info;
                    mover = mover.Next;
                }
                return null;
            }

            // Поиск по всей информации
            public LocalInformation FindElemInfo(LocalInformation info)
            {
                ListElem mover = this.Head;
                while (mover != null)
                {
                    if (mover.Info.OrganizationName == info.OrganizationName) return mover.Info;
                    mover = mover.Next;
                }
                return null;
            }

            // Поиск элемента в списке
            private ListElem FindElem(LocalInformation info)
            {
                ListElem mover = this.Head;
                while (mover != null)
                {
                    if (mover.Info.OrganizationName == info.OrganizationName && mover.Info.Adress == info.Adress) return mover;
                    mover = mover.Next;
                }
                return null;
            }
        };

        private const int _Size = 10000;
        public int Size
        {
            get { return _Size; }
        }

        public TwoLinkedList[] Table = new TwoLinkedList[_Size];

        private MainFrame OriginFrame;

        private LocalInformationHashTable() { }
        public LocalInformationHashTable(MainFrame OriginFrame)
        {
            this.OriginFrame = OriginFrame;
            for (int i = 0; i < _Size; i++)
            {
                Table[i] = new TwoLinkedList();
            }
        }

        // Хэш-функция - ключ логин
        private int hashFunc(LocalInformation info)
        {
            string OrganizationName = info.OrganizationName;

            int key = 0;

            foreach (char ch in OrganizationName)
            {
                key += (int)ch;
            }
            key = key % _Size; 

            return key % _Size;
        }

        public bool Add(LocalInformation info)
        {
            int key = hashFunc(info);
            bool SuccessfulAdd = Table[key].Add(info);

            if (SuccessfulAdd)
            {
                OriginFrame.AddLog("[Хэш:Организация-Адрес] Добавлен новый элемент: Организация - " + info.OrganizationName + ", Адрес - " + info.Adress + ", хэш: " + key);

            }
            else
            {
                OriginFrame.AddLog("[Хэш:Организация-Адрес] Попытка добавить уже имеющейся организации!");
            }
            return SuccessfulAdd;
        }



        public List<LocalInformation> FindByAdress(string Adress)
        {
            List<LocalInformation> result = new List<LocalInformation>();
            for (int i =0; i< _Size; i++)
            {
                var mover = Table[i].Head;
                while (mover != null)
                {
                    if (mover.Info.Adress == Adress)
                        result.Add(mover.Info);
                    mover = mover.Next;
                }
            }
            return result;
        }

        public LocalInformation Find(LocalInformation info)
        {
            int key = hashFunc(info);

            LocalInformation ElemContainer = Table[key].FindElemInfo(info);
            if (ElemContainer != null)
            {
                return ElemContainer;
            }
            else
            {
                return null;
            }
        }

        public bool Remove(LocalInformation info)
        {
            int key = hashFunc(info);
            bool SuccessfulDelete = Table[key].Remove(info);
            return SuccessfulDelete;
        }

        public void ClearHashTable()
        {
            for (int i = 0; i < _Size; i++)
            {
                Table[i].Clear();
            }
        }
    };

}
