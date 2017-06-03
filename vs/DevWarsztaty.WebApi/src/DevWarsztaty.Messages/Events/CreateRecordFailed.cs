namespace DevWarsztaty.Messages.Events
{
    public class CreateRecordFailed
    {
        protected CreateRecordFailed()
        {
        }

        public CreateRecordFailed(string key, string reason)
        {
            Key = key;
            Reason = reason;
        }

        public string Reason { get; }
        public string Key { get; }
    }
}