using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_WEB_MVC.Models
{
    public class Atleta
    {
        public int ID { get; set; }

        public string Nome { get; set; }
         
        public string Modalidade { get; set; }

        public int Idade { get; set; }

        public string Celular { get; set; }
    }
}