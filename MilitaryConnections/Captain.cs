using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryConnections
{
        public class Captain : AbstractMilitary
        {
            public Captain(String name, Int32 stupidity, Int16 seniority) : base(name, stupidity, seniority)
            { }
        }
}
