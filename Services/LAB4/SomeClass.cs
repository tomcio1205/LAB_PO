using System.Runtime.CompilerServices;
using WebApplication3.Services.LAB4;

namespace WebApplication3.Services.LAB3
{
    public class SomeClass
    {
        public string Print(string text) 
        { 
            try
            {
                return text.Length.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidDepartmentException("Custom exception");
            }
        }
    }
}
