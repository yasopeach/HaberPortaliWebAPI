using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uyg03.ViewModel
{
    public class HaberModel
    {
        public int HaberId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int Foto { get; set; }
        public int Tarih { get; set; }
        public int KategoriId { get; set; }
        public string HaberKategoriAdi { get; set; }
        public int UyeId { get; set; }
        public int Okunma { get; set; }
        public string UyeKadi { get; internal set; }
    }
}