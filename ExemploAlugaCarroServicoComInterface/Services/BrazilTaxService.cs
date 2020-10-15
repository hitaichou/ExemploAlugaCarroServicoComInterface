namespace ExemploAlugaCarroServicoComInterface.Services
{
    class BrazilTaxService : ITaxService //não é herança, é a realização da interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
