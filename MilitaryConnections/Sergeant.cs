using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryConnections
{
    public class Sergeant : AbstractMilitary
    {
        public Sergeant(String name, Int32 stupidity, Int16 seniority) : base(name, stupidity, seniority)
        { }
    }
}
