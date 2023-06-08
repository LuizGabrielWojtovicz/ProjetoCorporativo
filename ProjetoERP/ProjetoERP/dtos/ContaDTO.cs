using ProjetoErp.Models;

namespace ProjetoErp.dtos
{
    public class ContaDTO
    {
        private ContaModel conta;
        private double saldo;


        public void setContaContabil(ContaModel conta)
        {
            this.conta = conta;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
    }
}
