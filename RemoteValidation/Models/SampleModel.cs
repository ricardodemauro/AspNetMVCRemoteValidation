using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidation.Models
{
    public class SampleModel
    {
        [Required]
        [Remote("CheckValidIP", "Home")]
        public string ClientIp { get; set; }
    }
}