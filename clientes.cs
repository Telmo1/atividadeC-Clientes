namespace Atividade01_Clientes
{
    public class clientes
    {
        // Definindo os atributos das classes

        public string nome {get; set;}

        public string endereco {get; set;}

        public float valor {get; set;}

        public float valorImposto {get; set;}

        public float total {get; set;}

        // Definindo o metodo para calcular o valor do imposto

        public virtual void calculoImposto(float calculo){
            this.valor = calculo;
            this.valorImposto = this.valor * 10 / 100;
            this.total = this.valor + this.valorImposto;
        }

    }
}