using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shortcut :IEntity
    {

        public int ShortcutId { get; set; }

        public int ProductId { get; set; }
    }
}
