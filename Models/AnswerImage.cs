using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.models
{
    public class AnswerImage
    {
        [Required]
        public  int AnswerImageId
        {
            get;
            set;
        }

        [Required]
        public string FileName
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

    }
}
