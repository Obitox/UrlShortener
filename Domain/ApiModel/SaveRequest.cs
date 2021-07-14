using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.ApiModel
{
    public class SaveRequest
    {
        [Required]
        public List<Link> Links { get; set; }
    }
}