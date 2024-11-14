
public class Conta
{
    private double saldo;
    public void SetSaldo(double s)
    {
        try
        {
            if (s >= 0)

            {
                saldo = s;
            }
            else
            {
                throw new Exception("O saldo não pode ser negativo");

            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
}

