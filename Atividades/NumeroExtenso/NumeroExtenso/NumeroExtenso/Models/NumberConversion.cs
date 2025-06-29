﻿namespace NumeroExtenso.Models{
    public class NumberConversion{

        public int Number { get; set; }
        public string ToExtenso(){

            if (Number == 0) return "zero";

            var unidades = new[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            var dezenas = new[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            var especiais = new[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            var centenas = new[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            var milhares = new[] { "", "mil", "milhão", "milhões" };

            string resultado = "";
            int milhar = Number / 1000;
            int resto = Number % 1000;

            if (milhar > 0){
                if (milhar == 1) resultado += " um mil";
                else resultado += ConvertCentenas(milhar) + " mil";

                if (resto > 0) resultado += " e ";
            }

            if (resto > 0) resultado += ConvertCentenas(resto);

            return resultado.Trim();
        }


        private string ConvertCentenas(int numero){

            var unidades = new[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            var dezenas = new[] { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            var especiais = new[] { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            var centenas = new[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            if (numero == 100)
                return "cem";

            int centena = numero / 100;
            int dezena = (numero % 100) / 10;
            int unidade = numero % 10;

            string resultado = "";

            if (centena > 0) resultado += centenas[centena];

            if (dezena > 1){
                resultado += " " + dezenas[dezena];
                if (unidade > 0) resultado += " e " + unidades[unidade];
            }
            else if (dezena == 1 || unidade > 0){
                if (dezena == 1) resultado += " " + especiais[unidade];
                else resultado += " " + unidades[unidade];
            }
            return resultado.Trim();
        }
    }
}

