using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public static int ID { get; set; } = 111;

        public abstract int IdNumber(); // implicitly virtual
    }
}
