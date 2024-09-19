namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // Changes for Sprint 2 -- As a system admin, I want to be able to set a limit to the number of users in any one room -- Michael Ludwig

        // Changes for Sprint 1 -- As a mesage posting user, I want to create rooms for categorizing conversations
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
            //Add new atribute for userLimit here

        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
