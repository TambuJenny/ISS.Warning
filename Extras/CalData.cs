using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.Warning.Extras
{
    class CalData
    {
        public DateTime CallData(DateTime a) 
        {
            int ano = a.Year;
            int mes = a.Month;
            int dia = a.Day;
            int dias = System.DateTime.DaysInMonth(ano,mes);
            DateTime retornoData;

            dia = dia - 10;
            if (dia <0)
            {
                dia = dias + dia;
                mes = mes - 1;
                if(mes == 0) { mes = 12; }
                ano = a.Year - DateTime.Now.Year;
                ano = DateTime.Now.Year - ano;

            }
            else
            {
                ano = a.Year - DateTime.Now.Year;
                ano = DateTime.Now.Year - ano;

            }

            retornoData = new DateTime(ano, mes, dia);

            return retornoData;

        }
    }
}
