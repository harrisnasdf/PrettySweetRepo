using System;
using System.Collections.Generic;
using System.Text;

namespace MoniHealth.Models
{
    class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string errorDescription { get; set; }
        public DateTime expireDate { get; set; }

        public Token()
        {

        }
    }
}
