using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MobilApi.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public int Rotation { get; set; }
        public byte[] Image { get; set; }
    }
}