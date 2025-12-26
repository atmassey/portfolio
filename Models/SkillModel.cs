namespace portfolio.Models
{
    public class SkillModel
    {
        public string Name { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Category { get; set; } = "";
        public SkillLevel Level { get; set; } = SkillLevel.Beginner;
        public string Description { get; set; } = "";
        public string[] RelatedTechnologies { get; set; } = Array.Empty<string>();
        public string Color { get; set; } = "#6c757d";
    }

    public enum SkillLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
        Expert = 4
    }
}