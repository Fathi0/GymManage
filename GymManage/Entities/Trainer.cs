using GymManage.Entities.Enums;

namespace GymManage.Entities
{
    public class Trainer:GymUser
    {
        public Speciality Speciality { get; set; }
        public ICollection<Session> Sessions { get; set; }

    }
}
