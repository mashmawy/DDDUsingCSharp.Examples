namespace DDDUsingCSharp.Examples.Example1
{
    public abstract class Entity
    {
        public int Id { get;protected set; }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (!(obj is Entity)) return false;
            if (ReferenceEquals(this, obj)) return true;

            if (GetType() != obj.GetType()) return false;
            Entity item = (Entity)obj;
            if (item.Id == default || Id== default)
            {
                return false;
            }
            else
            {
                return item.Id == Id;
            }
             
        }

        public override int GetHashCode()
        {
            if (Id != default)
                return Id.GetHashCode() ^ 31;
            return base.GetHashCode();
        }

        public static bool operator == (Entity left,Entity right)
        {
            if (Equals(left,null))
            {
                return Equals(right, null) ? true : false;

            }
            else
            {
                return left.Equals(right);
            }
        }
        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}