namespace MeetingApp.Models
{
    public class MeetingInfo
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }
        
    }
}