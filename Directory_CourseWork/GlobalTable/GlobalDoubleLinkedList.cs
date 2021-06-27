using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_CourseWork
{
	public class GlobalDoubleLinkedList
	{
		public ListElem Head = null;
		public ListElem Tail = null;

		// Иниц. элементов списка
		public class ListElem
		{
			public ListElem Prev { get; set; }
			public GlobalInformation Info { get; set; }
			public ListElem Next { get; set; }
		};

		// Конструктор
		public GlobalDoubleLinkedList() { }

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

		// Добавление элемента
		public bool Add(GlobalInformation info)
        {
			if ( this.FindElemInfo(info.OrganizationName, info.Adress) != null ) return false;

			var Elem = new ListElem();
			Elem.Info = (GlobalInformation)info.Clone();

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

		public bool Remove(GlobalInformation info)
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
		public GlobalInformation FindElemInfo(string OriganizationName, string Adress)
        {
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info.OrganizationName == OriganizationName && mover.Info.Adress == Adress) return mover.Info;
				mover = mover.Next;
			}
			return null;
		}

		// Поиск по всей информации
		public GlobalInformation FindElemInfo(GlobalInformation info)
		{
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info == info) return mover.Info;
				mover = mover.Next;
			}
			return null;
		}

		// Поиск элемента в списке
		private ListElem FindElem(GlobalInformation info)
		{
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info == info) return mover;
				mover = mover.Next;
			}
			return null;
		}
	};
}
