namespace codepush_winform.helper
{
    public class Release
    {
        public string target_binary_range { get; set; }
        public string blob_url { get; set; }
        public string description { get; set; }
        public bool is_disabled { get; set; }
        public bool is_mandatory { get; set; }
        public string label { get; set; }
        public string hash { get; set; }
        public string released_by { get; set; }
        public string release_method { get; set; }
        public int rollout { get; set; }
        public int size { get; set; }
        public long upload_time { get; set; }

        public override string ToString()
        {
            return label;
        }
    }
}