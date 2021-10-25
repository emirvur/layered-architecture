using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredArchitecture.WebAPI.Dto
{
    public class ErrorDto
    {
        public ErrorDto()
        {
            Errors = new List<string>();
        }

        public List<String> Errors { get; set; }
        public int Status { get; set; }
    }
}
