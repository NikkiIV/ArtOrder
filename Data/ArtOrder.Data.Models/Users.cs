namespace ArtOrder.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ArtOrder.Data.Common.Models;

    public class Users : BaseDeletableModel<string>
    {
        public string Role { get; set; }

        public string Name { get; set; }

        public decimal Age { get; set; }
    }
}
