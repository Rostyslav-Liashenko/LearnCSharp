namespace LearnFeatures
{
    public class MessageDetails
    {
        public string Language { get; set; }
        public string DataTime { get; set; }
        public string Status { get; set; }

        public void Deconstruct(out string lang, out string dateTime, out string status)
        {
            lang = Language;
            dateTime = DataTime;
            status = Status;
        }
    }
}
