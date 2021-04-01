using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public enum Rank
    {
        Pvt,
        PFC,
        LCpl,
        Cpl,
        Sgt,
        SSgt,
        GySgt,
        MSgt,
        [Display(Name = "1stSgt")]
        lstSgt ,
        MGySgt,
        SgtMaj
        // https://classroom.synonym.com/abbreviations-for-military-ranks-13583770.html
    }
}
