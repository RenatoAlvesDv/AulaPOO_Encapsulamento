namespace AulaPOO_Encapsulamento
{
    public class Cartao
    {
        // declaração dos atributos
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string bandeira = "MasterCard";
        private string Bandeira{
            get{return bandeira;}
            //set{bandeira = value;}
        }


        protected string token = "qwertyui";
        
        public string  Token{
            get{return token;}
        }
         private string cvv;

         public string Cvv{
             get{return cvv;}
             set{ cvv = value;}
         }
        protected float limite = 5000;


        // declaração dos metodos

        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo){

            return true;
        }

        protected string ValidarToken( string token){
                return "";
        }

    }
}