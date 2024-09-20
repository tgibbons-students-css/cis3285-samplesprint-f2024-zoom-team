namespace CIS3285_Unit3Sample_2024.Models

// Changes for Sprint #2 -- User Story 2D -- Mikita Puntus
// Changes Sprint 2D -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Mikita Puntus

/// <summary>
/// Developer: Mikita Puntus
/// In Models: public class RoomRecord
///  Simply put a comment in the RoomRecord.cs file where we would add an new attribute for the userLimit.
/// </summary>





{
    public class RoomRecord
    {
        // Changes for Sprint 1 -- As a mesage posting user, I want to create rooms for categorizing conversations -- Briston Domino

        // Putting a comment
        // Changes for Sprint #2 -- User Story 2D -- Mikita Puntus
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
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
