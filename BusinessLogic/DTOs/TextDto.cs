using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.DTOs
{
    public class TextDto
    {
        public int Id { get; set; }
        public string Input { get; set; }
        public IFormFile File { get; set; }
        public string Content { get; set; }
    }
}
