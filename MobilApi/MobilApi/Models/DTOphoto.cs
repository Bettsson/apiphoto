using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilApi.Models
{
    public class DTOphoto
    {
        public int id { get; set; }
        public string imageAsString { get; set; }


        public DTOphoto (Photo photo)
        {
            id = photo.Id;
            imageAsString = Convert.ToBase64String(photo.Image);
        }
    }
}