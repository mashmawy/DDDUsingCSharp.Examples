namespace DDDUsingCSharp.Examples.Example1
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetObjectValues();


        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj,null) || obj.GetType() != GetType())
            {
                return false;
            }

            ValueObject other = (ValueObject)obj;

            IEnumerator<object> myvalues = GetObjectValues().GetEnumerator();
            IEnumerator<object> othervalues = other.GetObjectValues().GetEnumerator();
            while (myvalues.MoveNext() && othervalues.MoveNext())
            {
                if (ReferenceEquals(myvalues.Current,null) ^ ReferenceEquals(othervalues.Current,null))
                {
                    return false;
                }
                if (myvalues.Current !=null && !myvalues.Current.Equals(othervalues.Current))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return GetObjectValues().Select(x=> x!=null ? x.GetHashCode():0)
                .Aggregate((x,y) => x^y);
        }

        public static bool operator == (ValueObject obj1,ValueObject obj2)
        {
            if (ReferenceEquals(obj1,null))
            {
                return ReferenceEquals(obj2,null) ? true:false;
            }
            else
            {
                return obj1.Equals(obj2);
            }
        }
        public static bool operator !=(ValueObject obj1, ValueObject obj2)
        {
            return !(obj1 != obj2);
        }
    }
}