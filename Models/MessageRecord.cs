namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes for Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations -- Michael Ludwig
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }
        
        // Changes for Sprint 2 -- As a system administrator, I want to serve hundreds of users concurrently. -- Michael Ludwig
        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }
        // Changes for Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations -- Michael Ludwig
        public string AuthorName
        {
            get;
            private set;
        }
    }
}
