using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryConnections
{
    public static class MilitaryFactory
    {
        public static AbstractMilitary Create(String name, Int32 stupidity, Int16 seniority)
        {
            AbstractMilitary military;
            if ((seniority > 0 && seniority <= 6) && (stupidity > 0 && stupidity <= 10))
            {
                military = new Grunt(name, stupidity, seniority);
            }   
            else if ((seniority > 6 && seniority <= 24) && (stupidity > 10 && stupidity <= 30))
            {
                military = new Sergeant(name, stupidity, seniority);
            }
            else if ((seniority > 24 && seniority < 64) && (stupidity > 30 && stupidity < 80))
            {
                military = new Captain(name, stupidity, seniority);
            }
            else if (seniority > 64 && stupidity > 80)
            {
                military = new General(name, stupidity, seniority);
            }
            else
            {
                throw new ArgumentException($"There are no rank for: stupidity = {stupidity} and seniority = {seniority}");
            }
            return military;
        }
    }
}
