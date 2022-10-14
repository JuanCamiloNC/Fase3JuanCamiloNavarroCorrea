using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3JuanCamiloNavarroCorrea
{
    internal class PilaCDT
    {
        //Atributos
        public double numeroDelCDT { get; set; }
        public double numeroDeIdentificacion { get; set; }
        public int estrato { get; set; }
        public string categoria { get; set; }
        public double ingresarUnValor { get; set; }
        public string mesDeApertura { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string tiempoDelCDT { get; set; }
        public string totalAPagar { get; set; }
        private double tasaDeInteres { get; set; }
        

        //Metodo
        public double calcularElPago()
        {
            if (Convert.ToInt32(this.tiempoDelCDT) > 0 && Convert.ToInt32(this.tiempoDelCDT) <= 12)
            {
                this.tasaDeInteres = 0.2;
            }
            if (Convert.ToInt32(this.tiempoDelCDT) >= 13 && Convert.ToInt32(this.tiempoDelCDT) <= 24)
            {
                this.tasaDeInteres = 0.3;
            }
            if(Convert.ToInt32(this.tiempoDelCDT) >= 25)
            {
                this.tasaDeInteres = 0.5;
            }
            
            double cuenta = this.ingresarUnValor + this.ingresarUnValor * (this.tasaDeInteres / 100) * 
                Convert.ToDouble(this.tiempoDelCDT);
            return cuenta;
        }
    }
}
