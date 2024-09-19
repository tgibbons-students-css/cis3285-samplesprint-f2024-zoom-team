namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes for Sprint 2 -- As a message poster, I want to send markdown text that will be correctly formatted -- Michael Ludwig
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        // Changes for Sprint 2 -- As a message poster, I want to send markdown text that will be correctly formatted -- Michael Ludwig
        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
