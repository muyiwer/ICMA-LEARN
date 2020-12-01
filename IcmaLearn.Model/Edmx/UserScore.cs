﻿using System;
using System.Collections.Generic;

#nullable disable

namespace IcmaLearn.Model.Edmx
{
    public partial class UserScore
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public DateTime? DateCreated { get; set; }
        public decimal? Score { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}