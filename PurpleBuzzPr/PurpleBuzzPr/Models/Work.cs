using PurpleBuzzPr.Models.Base;

namespace PurpleBuzzPr.Models
{
    public class Work : BaseAuditableEntity
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainImageUrl { get; set; }
        
    }
}
