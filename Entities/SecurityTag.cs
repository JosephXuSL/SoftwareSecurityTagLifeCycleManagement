namespace SSTLifeCycleManagement.Entities
{
    public class SecurityTag
    {
        public int Id { get; set; }
        public string AppId { get; set; }
        public string AppName { get; set; }
        public string Version { get; set; }
        public string Memory { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public DateTime DevelopTime { get; set; }
        public string Signature { get; set; }
        public int MaxUsers { get; set; }
        public string Status { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
