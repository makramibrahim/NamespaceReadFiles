using System;
using System.Collections.Generic;
using System.Text;

namespace ReadFiles
{
    class Account
    {
        public string Email        { get; set; }
        public bool Active         { get; set; }
        public DateTime CreateDate { get; set; }
        public List<string> Roles  { get; set; }

    }
}
