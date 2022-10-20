using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3JuanCamiloNavarroCorrea
{
    internal class ColaJuventud
    {
        //Atributos 
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Comunas { get; set; }
        public string Genero { get; set; }
        public DateTime Fecha { get; set; }
        public double auxilio { get; set; }
        public DateTime ProximoPago { get; set; }

        //Metosdos o Funciones
        
        public double auxilioEconomico()
        {
            if (Convert.ToDouble(this.Comunas) == 1 || Convert.ToDouble(this.Comunas) == 8 
                || Convert.ToDouble(this.Comunas) == 10)
            {
                this.auxilio = 100000;
            }
            else if (Convert.ToDouble(this.Comunas) != 1 || Convert.ToDouble(this.Comunas) != 8
                || Convert.ToDouble(this.Comunas) != 10)
            {
                this.auxilio = 50000;
            }
            return this.auxilio;
        }
        public DateTime calcularMeses()
        {
            //Los 90 dias son tres meses
            this.ProximoPago = this.Fecha.AddDays(90);
            return this.ProximoPago;
        }
    }
}
