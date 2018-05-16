namespace StrongTypeSession.Models
{
    public class Member : SessionInfo<Member>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}