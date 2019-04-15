namespace ex1
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numeroConta;
        public double saldoConta{get;private set;}

        public void Depositar(double valor){
            saldoConta +=valor;
        }

        public bool Sacar(double valor){
            if (saldoConta < valor){
                return false;
            }else{
                saldoConta-=valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente contaDestino){

            if (valor > saldoConta){
                return false;
            }else{
                saldoConta-=valor;
                contaDestino.saldoConta+=valor;
                return true;
            }

        }

    }
}