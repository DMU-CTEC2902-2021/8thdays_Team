﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFootBallClub.Models
{
    public class Player
    {
        public int ID { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int Goals { get; set; }
        public int Assist { get; set; }
        public int Played { get; set; }
        public int TotalShots { get; set; }
        public int GoalConversion { get; set; }
        public int ShotAccuracy { get; set; }
    }
}