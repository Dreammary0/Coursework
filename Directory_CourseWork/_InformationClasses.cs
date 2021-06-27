using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_CourseWork
{
    // Класс общей таблицы
    public class GlobalInformation : ICloneable, IEquatable<GlobalInformation>
    {
        public string OrganizationName; //данные для общей
        public string Adress;
        public string Sale;

        public override int GetHashCode()   
        {
            return OrganizationName.GetHashCode() ^ Adress.GetHashCode() ^ Sale.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is GlobalInformation))
                return false;

            return Equals((GlobalInformation)obj);
        }

        public bool Equals(GlobalInformation other)
        {
            if (OrganizationName != other.OrganizationName ||
                Adress != other.Adress
                || Sale != other.Sale
            )
            {
                return false;
            }
                

            return true;
        }

        public static bool operator ==(GlobalInformation Info1, GlobalInformation Info2)
        {
            if (Info1 is null && Info2 is null) return true;
            if (Info1 is null || Info2 is null) return false;

            return Info1.Equals(Info2);
        }

        public static bool operator !=(GlobalInformation Info1, GlobalInformation Info2)
        {
            if (Info1 is null && Info2 is null) return false;
            if (Info1 is null || Info2 is null) return true;

            return !Info1.Equals(Info2);
        }

        public object Clone()
        {
            return new GlobalInformation
            {
                OrganizationName = this.OrganizationName,
                Adress = this.Adress,
                Sale = this.Sale
            };
        }
    }

    public class LocalInformation : ICloneable, IEquatable<GlobalInformation>
    {
        public string OrganizationName;
        public string Adress;

        public override int GetHashCode()
        {
            return OrganizationName.GetHashCode() ^ Adress.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is GlobalInformation))
                return false;

            return Equals((GlobalInformation)obj);
        }

        public bool Equals(GlobalInformation other)
        {
            if (OrganizationName != other.OrganizationName ||
                Adress != other.Adress
            )
            {
                return false;
            }


            return true;
        }

        public static bool operator ==(LocalInformation Info1, LocalInformation Info2)
        {
            if (Info1 is null && Info2 is null) return true;
            if (Info1 is null || Info2 is null) return false;

            return Info1.Equals(Info2);
        }

        public static bool operator !=(LocalInformation Info1, LocalInformation Info2)
        {
            if (Info1 is null && Info2 is null) return false;
            if (Info1 is null || Info2 is null) return true;

            return !Info1.Equals(Info2);
        }

        public object Clone()
        {
            return new LocalInformation
            {
                OrganizationName = this.OrganizationName,
                Adress = this.Adress,
            };
        }
    }
}
