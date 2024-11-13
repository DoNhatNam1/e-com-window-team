using System;
using System.Collections.Generic;

namespace EComWindowTeam.HomeMvc.Models
{
    public class TbUser
    {
        
        public string? id { get; set; }
        public string? email { get; set; }
        public List<TbOrder> orders { get; set; } = new List<TbOrder>();
        public bool IsActive { get; set; } = true;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}