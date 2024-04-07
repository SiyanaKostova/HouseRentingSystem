using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House Title")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House Address")]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House Description")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("House Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Comment("House Monthly Price")]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), HousePricePerMonthMinLength, HousePricePerMonthMaxLength, ConvertValueInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        [Comment("User id of the renter")]
        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public ApplicationUser? Renter { get; set; }

        [Comment("Shows whether house approved by admin")]
        public bool IsApproved { get; set; }
    }
}