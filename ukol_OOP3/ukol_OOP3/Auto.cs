using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ukol_OOP3
{
    public class Auto
    {
        private string znacka;
        private double spotreba;
        public double ujetocelkem;
        private DateTime okamzikrozjezdu;
        private DateTime dobajizdycelkem;
        public bool jede { get; private set; }

  
        public Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            this.ujetocelkem = 0;
           this.dobajizdycelkem = new DateTime(0,0,0,0,0,0);
            jede = false;
        }
        public double VratUjeteKm()
        {
            return ujetocelkem;
        }
        public void Rozjed()
        {
            jede = true;
            okamzikrozjezdu = DateTime.Now;
        }
        public void Zastav (double ujetokm)
        {
            jede = false;
            ujetocelkem = ujetocelkem + ujetokm;
            dobajizdycelkem = dobajizdycelkem + (DateTime.Now - okamzikrozjezdu);
        }
        public double CelkovaSpotreba()
        {
            return (spotreba / 100) * ujetocelkem;
        }
        public override string ToString()
        {
            if (jede == true)
            {
               return String.Format("Auto značky {0} má najeto {1}.\n Jeho spotřeba je {2},\n Bylo spotřebováno {3} a auto momentálně jede!", znacka, ujetocelkem, spotreba, CelkovaSpotreba());
            }
            else
            {
                return String.Format("Auto značky {0} má najeto {1}.\n Jeho spotřeba je {2},\n Bylo spotřebováno {3} a auto momentálně stojí!", znacka, ujetocelkem, spotreba, CelkovaSpotreba());
            }
        }

    }
}
