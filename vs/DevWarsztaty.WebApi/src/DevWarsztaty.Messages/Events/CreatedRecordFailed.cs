namespace DevWarsztaty.Messages.Events
{
    class CreatedRecordFailed
    {
        protected CreatedRecordFailed()
        {
        }

        public CreatedRecordFailed(string key, string reason)
        {
            Key = key;
            Reason = reason;
        }

        public string Reason { get; }
        public string Key { get; }
    }
}