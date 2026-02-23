namespace Verificador_de_Idade
{
    public class Person
    {
        public int Age;

        public string IfLegalPersonRefactor(int Age)
        {
           string result = string .Empty;

            if (Age >= 18)
            {
                result = "A pessoa é maior de idade!";
                return result;
			}
            else
            {
                result = "A pessoa é menor de idade!";
                return result; 
			}
		}
	}
}
