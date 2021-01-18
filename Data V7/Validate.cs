using System;

namespace Data_V7
{
    public class Validate
    {
        public static bool ValidateCedula(string cedula)
        {
            if (cedula.Length != 11 )
            {   
                Console.WriteLine("Tiene que ser 11 numeros");
                return false;
            }else
                return true;
        }
        public static bool ValidateName(string name)
        {

            if (name.Length == 0 )
            {   
                Console.WriteLine("No puedes dejarlo vacio");
                return false;
            }else
                return true;
        }
        public static bool ValidateAge(int age)
        {
            string a = Convert.ToString(age);
            if (a.Length == 0 )
            {   
                Console.WriteLine("No puedes dejarlo vacio");
                return false;
            }else
                return true;
        }
        public static bool ValidateSaving(decimal save)
        {
            string s = Convert.ToString(save);
            if (s.Length == 0 )
            {   
                Console.WriteLine("No puedes dejarlo vacio");
                return false;
            }else
                return true;
        }
        public static bool ValidatePassword(string password)
        {
            string confirmPassword = "";
            if (password.Length == 0 )
            {   
                Console.WriteLine("No puedes dejarlo vacio");
                return false;
            }else if (password.Length < 7 )
            {    
                Console.WriteLine("Tiene que ser tener mas de 6 caracteres.");
                return false;
            }else
            {
                Console.WriteLine();
                Console.Write("Confirme la contraseña: ");
                confirmPassword = Read.ReadString("*");
                if(password != confirmPassword)
                {
                    Console.WriteLine("Las contraseñas no coinciden.");
                    return false;
                }else
                    return true;
            }
        }
    }
}