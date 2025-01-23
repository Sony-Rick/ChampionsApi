using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChampionsApi.Api.Champios.app.app.domain
{
    public class Champions
    {
        public int Id { get; set; }	

        public string Nome { get; set; }

        public string Foto { get; set; }

        public int VidaBase { get; set; }

        public int ManaBase { get; set; }

        EnumTipodeCampeao enumTipodeCampeao{ get; set; }   

        EnumLane enumLane{ get; set; }

        public string Passiva { get; set; }

        public int Dano { get; set; }

        public List<Habilidades> habilidades { get; set;}
        
    }
}