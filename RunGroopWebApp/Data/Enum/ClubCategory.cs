using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Data.Enum
{
    public enum ClubCategory
    {
        [Display(Name = "Road Runner")]
        RoadRunner,
        Womens,
        City,
        Trail,
        Endurance
    }
}
