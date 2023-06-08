namespace ProjetoErp.dtos
{
    public class DRE
    {
        private double totalReceitas;
        private double totalDespesas;
        private double resultado;
        public void setReceitas(double totalReceitas)
        {
            this.totalReceitas = totalReceitas;
        }

        public void setDespesas(double totalDespesas)
        {
            this.totalDespesas = totalDespesas;
        }

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }
    }
}
