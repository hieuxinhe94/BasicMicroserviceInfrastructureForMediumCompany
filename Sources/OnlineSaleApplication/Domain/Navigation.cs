namespace Domains
{
    public class Navigation : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        public int? ParentId { get; set; }
        public virtual Navigation Parent { get; set; }
    }
}
