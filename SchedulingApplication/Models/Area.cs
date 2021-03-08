using System;
using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public enum EventType
    {
        PT,
        [Display( Name = "SQ BASIC")]
        SQBASIC,
        [Display(Name = "SQ INTERMEDIATE")]
        SQINTERMEDIATE ,
        WSA,
        OTHER
    }
    public enum Area
    {
        CampHorno = 53,
        SOI = 52,
        LasPulgas = 43
        //https://en.wikipedia.org/wiki/Marine_Corps_Base_Camp_Pendleton#Areas_of_Camp_Pendleton
    }

   
}
