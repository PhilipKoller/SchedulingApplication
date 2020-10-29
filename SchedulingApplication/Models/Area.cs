using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public enum EventType
    {
        Pt,
        Sq,
        Other
    }
    public enum Area
    {
        CampHorno = 53,
        SOI = 52,
        LasPulgas = 43
        //https://en.wikipedia.org/wiki/Marine_Corps_Base_Camp_Pendleton#Areas_of_Camp_Pendleton
    }
}
