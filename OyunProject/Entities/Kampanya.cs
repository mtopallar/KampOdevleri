using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract.Imzalama;

namespace OyunProject.Entities
{
    public class Kampanya:IEntity
    {
        public int Id { get; set; }
        public string KampanyaAdi { get; set; }
        public int IndirimOranı { get; set; }
    }
}
