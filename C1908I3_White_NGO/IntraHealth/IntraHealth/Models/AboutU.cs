using System;
using System.Collections.Generic;

#nullable disable

namespace IntraHealth.Models
{
    public partial class AboutU
    {
        public int IdAboutUs { get; set; }
        public string NameAboutus { get; set; }
        public string WhatWedoUs { get; set; }
        public string OurMissionUs { get; set; }
        public string OurTeamUs { get; set; }
        public string CareerWithUs { get; set; }
        public string OurAchievementsUs { get; set; }
        public string OurSupportersUs { get; set; }
        public string RedAboutUs { get; set; }
        public DateTime? TimeCreateUs { get; set; }
        public bool? StatusUs { get; set; }
    }
}
