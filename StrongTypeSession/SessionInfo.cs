using System.Web;

namespace StrongTypeSession
{
    public class SessionInfo<Subclass>
        where Subclass : SessionInfo<Subclass>, new()
    {
        private static string Key
        {
            get { return typeof(SessionInfo<Subclass>).FullName; }
        }

        private static Subclass Value
        {
            get { return (Subclass)HttpContext.Current.Session[Key]; }
            set { HttpContext.Current.Session[Key] = value; }
        }

        public static Subclass Current
        {
            get
            {
                var instance = Value;
                if (instance == null)
                    lock (typeof(Subclass))
                    {
                        instance = Value;
                        if (instance == null)
                            Value = instance = new Subclass();
                    }

                return instance;
            }

        }
    }
}