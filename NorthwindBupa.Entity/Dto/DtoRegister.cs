using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindBupa.Entity.Dto
{
    public class DtoRegister
    {
            [Required]
            public string UserName { get; set; }
            [Required]
            public string UserLastName { get; set; }
            [Required]
            public string UserCode { get; set; }
            [Required]
            public string Password { get; set; }
                     
    }
}
