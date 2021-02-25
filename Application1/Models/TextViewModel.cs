using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application1.Models
{
    public class TextViewModel
    {
        public int Id { get; set; }
        public string Input { get; set; }
        public IFormFile File { get; set; }
        public string Content { get; set; }
    }
}
