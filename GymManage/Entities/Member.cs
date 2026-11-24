namespace GymManage.Entities
{
    public class Member:GymUser
    {
        public string? Photo { get; set; }
        public ICollection<Membership> Plans { get; set; }
    }
}
