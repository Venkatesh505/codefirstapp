using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirstapp.Dtos
{
    public class PlayersDto
    {
        public int PlayersID { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
    }
}