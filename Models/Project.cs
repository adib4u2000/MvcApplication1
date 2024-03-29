﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Project
    {
        public string ProiectName { get; set; }
        [Required]
        public string SSN { get; set; }
        public string HasBacklocks { get; set; }
        public string ProjectManager { get; set; }

        [DisplayName("Start date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayName("Estimated end date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DateGreaterThan("StartDate", "Estimated end date must be greater than the start date of the project")]
        public DateTime EndDate { get; set; }
    }
}