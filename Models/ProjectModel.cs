namespace portfolio.Models
{
    public class ProjectModel
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "bi-code-square";
        public string Category { get; set; } = "";
        public string[] Technologies { get; set; } = Array.Empty<string>();
        public string GitHubUrl { get; set; } = "";
        public string? LiveUrl { get; set; }
        public string Status { get; set; } = "Active";
    }
}