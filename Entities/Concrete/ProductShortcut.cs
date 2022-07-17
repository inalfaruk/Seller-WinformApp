using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductShortcut :IEntity
    {

        public int ProductShortcutId { get; set; }

        public int ProductId { get; set; }
    }
}
