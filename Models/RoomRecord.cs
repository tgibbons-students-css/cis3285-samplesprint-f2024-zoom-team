namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // Changes for Sprint 1 -- As a mesage posting user, I want to create rooms for categorizing conversations
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }


        // Changes for Sprint 2 -- User Story -- Briston Domino
        // Changes Sprint 2 -- As a system administrator, I want to serve hundreds of users concurrently.
        public string Name
        {
            get;
            private set;
        }
    }
}
