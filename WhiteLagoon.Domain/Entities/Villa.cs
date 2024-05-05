using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhiteLagoon.Domain.Entities
{
    public class Villa
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10,10000)]
        public double? Price { get; set; }
        public int Sqm {  get; set; }
        [NotMapped]
        public IFormFile? Image{ get; set; }
        [Range(1,10)]
        public int Occupancy { get; set; }
        [Display(Name = "Image url")]
        public string? ImageUrl {  get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        [ValidateNever]
        public IEnumerable<Amenity> VillaAmenity { get; set; }

    }
}
