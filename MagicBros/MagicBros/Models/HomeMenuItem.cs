using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBros.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Teste
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
