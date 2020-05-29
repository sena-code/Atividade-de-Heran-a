namespace Atividade_6
{
    public class CNPJ : Person
    {
        public string cnpj;
        public bool ValidateCNPJ(){

            if(cnpj != "0"){
                return true;
            } return false;
        }
    }
}