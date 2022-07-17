using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ShortcutDetailDto :IDto
    {
        public int ProductShortcutId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Barcode { get; set; }
    }
}
