﻿
public class Conta
{
    private double saldo;
    public void SetSaldo(double s)
    {
        if (s >= 0)

        {
           saldo  = s;
        }
        else
        {
            Console.WriteLine("saldo incorreto");
        }
    }

}


