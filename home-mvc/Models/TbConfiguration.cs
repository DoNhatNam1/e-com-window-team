using System.Collections.Generic;

namespace EComWindowTeam.HomeMvc.Models
{
    public class TbConfiguration
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public int Width { get; set; }
        public int Height { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string? Color { get; set; }
        public string? Model { get; set; }
        public string? Material { get; set; }
        public string? Finish { get; set; }
        public string? CroppedImageUrl { get; set; }

        // Navigation property
        public ICollection<TbOrder> Orders { get; set; } = new List<TbOrder>();
    }
}