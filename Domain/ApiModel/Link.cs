using System.ComponentModel.DataAnnotations;

namespace Domain.ApiModel
{
    public class Link
    {
        public long LinkId { get; set; }
        [Required]
        public string LinkFullValue { get; set; }
        [Required]
        public string LinkShortValue { get; set; }
    }
}