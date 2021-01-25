using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using OyunProject.Abstract.Entities;

namespace OyunProject.Entities
{
    public class Oyun:IEntity
    {
        public int Id { get; set; }
        public string OyunAdi { get; set; }
        public decimal OyunFiyat { get; set; }
        
        
    }
}
