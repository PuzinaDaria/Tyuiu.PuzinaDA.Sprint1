using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PuzinaDA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            int c = 0;
            string alfavit = "йцукенгшщзхъфывапролджэячсмитьбю ";
            for (int i = 0; i < value.Length; i++)
            {
                char wr = value[i];
                for (int j = 0; j < alfavit.Length; j++)
                {
                    char wd = alfavit[j];
                    if (wr == wd)
                    {
                        c = c + 1;
                    }
                }
            }
            if (c == value.Length)
            {
                return true;
            } 
            else return false;
                
            
            throw new NotImplementedException();

        }
    }
}
