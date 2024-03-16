using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Laurente
{
    public class CajeroAutomatico : CuentaBancaria
    {
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo actual: {saldo} soles");
        }

        public void DepositarFondos(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("Cantidad inválida para depósito.");
            }

            saldo += cantidad;
            Console.WriteLine($"Se depositaron {cantidad} soles. Nuevo saldo: {saldo} soles");
        }

        public void RetirarEfectivo(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("Cantidad inválida para retiro.");
            }

            if (cantidad > saldo)
            {
                throw new InvalidOperationException("Fondos insuficientes.");
            }

            saldo -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} soles. Saldo restante: {saldo}");
        }

        public void CambiarPIN(int nuevoPIN)
        {
            if (nuevoPIN == PIN)
            {
                throw new InvalidOperationException("El nuevo PIN no puede ser igual al PIN actual.");
            }

            if (nuevoPIN <= 999 || nuevoPIN >= 10000)
            {
                throw new ArgumentException("El PIN debe tener 4 dígitos.");
            }

            PIN = nuevoPIN;
            Console.WriteLine("PIN cambiado exitosamente.");
        }
    }
}