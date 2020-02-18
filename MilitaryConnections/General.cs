using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryConnections
{
    public class General: AbstractMilitary
    {
        public General(String name, Int32 stupidity, Int16 seniority) : base(name, stupidity, seniority)
        { }
    }
}
