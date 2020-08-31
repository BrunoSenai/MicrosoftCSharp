using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.utils
{
    class Utils
    {
        public static bool validarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, dig1, dig2;

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11
                || cpf.Equals("00000000000") || cpf.Equals("11111111111")
                || cpf.Equals("22222222222") || cpf.Equals("33333333333")
                || cpf.Equals("44444444444") || cpf.Equals("55555555555")
                || cpf.Equals("66666666666") || cpf.Equals("77777777777")
                || cpf.Equals("88888888888") || cpf.Equals("99999999999"))
            {
                return false;
            }
            else
            {

                // digito 2
                for (int i = 0; i < 9; i++)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                    peso--;
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    dig1 = 0;
                }
                else
                {
                    dig1 = 11 - resto;
                }

                if (Convert.ToInt32(cpf[9].ToString()) != dig1)
                {
                    return false;
                }

                // digito 2
                soma = 0;
                peso = 11;

                for (int i = 0; i < 10; i++)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                    peso--;
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    dig2 = 0;
                }
                else
                {
                    dig2 = 11 - resto;
                }

                if (Convert.ToInt32(cpf[10].ToString()) != dig2)
                {
                    return false;
                }
                return true;
            }

        }
    }
}
