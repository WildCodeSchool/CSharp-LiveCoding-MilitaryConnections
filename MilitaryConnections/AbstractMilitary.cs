using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryConnections
{
    public abstract class AbstractMilitary
    {
        public String Name { get; private set; }
        public Int32 Stupidity { get; private set; }
        public Int16 Seniority { get; private set; }

        public List<AbstractMilitary> Subordinates { get; private set; }
        
        public IEnumerable<AbstractMilitary> DivisionSubordinates 
        { 
            get
            {
                foreach (AbstractMilitary military in Subordinates)
                {
                    yield return military;
                    foreach (AbstractMilitary subordinate in military.DivisionSubordinates)
                    {
                        yield return subordinate;
                    }
                }
            }
        }

        public AbstractMilitary(String name, Int32 stupidity, Int16 seniority)
        {
            Name = name;
            Stupidity = stupidity;
            Seniority = seniority;
            Subordinates = new List<AbstractMilitary>();
        }
    }
}
