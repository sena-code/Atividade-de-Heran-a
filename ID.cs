namespace Atividade_6
{
    public class CPF : Person 
    {
        public string id;
        public string rg;
        public bool ValidateID(){

            if(id != "0"){
                return true;
            } return false;
        }
    }
}