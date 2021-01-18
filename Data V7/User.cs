
using System;

namespace Data_V7
{
    public class User
    { 
        public string cedula {get;}
        public string name {get;}
        public string lastName {get;}
        public string sex {get;}
        public int age {get;}
        public decimal save {get;}
        public string password {get;}
        public string grade {get;}
        public string civilStatus {get;}
        public User(string[] register)
        {
            cedula = register[0];
            name = register[1];
            lastName = register[2];
            save = Convert.ToDecimal(register[3]);
            password = register[4];
            int code;
            string decoded = "";
            if(register.Length >6)
            {code = ToCode(register[5], Convert.ToInt16(register[6]));
            decoded = Decode(code);}
            else
                decoded = Decode(Convert.ToInt16(register[5]));
            string[] d = decoded.Split(",");
            age = Convert.ToInt16(d[0]);
            sex = d[1];
            civilStatus = d[2];
            grade = d[3];
        }
        public string ToFile()
        {
            string toCode = sex[0].ToString() + civilStatus[0].ToString() + grade[0].ToString();
            int code = ToCode(toCode, age);
            return cedula + "," + name + "," + lastName + "," + save + "," + password + "," + code;
        }
        public string ToShow()
        {
            return cedula + "," + name + "," + lastName + "," + sex + "," + save + "," + age + "," + civilStatus + "," + grade + "," + password;
        }
         private string Decode(int code)
        {
            string decoded = "";
            string grado = "";
            string estado = "";
            string sexo = "";
            if(code == (code|1))
                grado = "Media";
            else if(code == (code|2))
                grado = "Grado";
            else if(code == (code|3))
                grado = "Post-grado";
            else
                grado = "Inicial";
            if(code == (code|4))
                estado = "Casado";
            else 
                estado = "Soltero";
            if(code == (code|8))
                sexo = "Femenino";
            else 
                sexo = "Masculino";
            int edad = code >> 4;
            decoded = edad + "," + sexo + "," + estado + "," + grado;
            return decoded;
        }
        private int ToCode(string toCode,int age)
        {
            int code = 0;
            code = code | age;
            code = code << 4;
            switch(toCode[0].ToString().ToLower())
            {
                case "f":
                    code = code | 8;
                    break;
                case "m":
                    break;
            }
            switch(toCode[1].ToString().ToLower())
            {
                case "c":
                    code = code | 4;
                    break;
                case "s":
                    break;
            }
            switch(toCode[2].ToString().ToLower())
            {
                case "i":
                    break;
                case "m":
                    code = code | 1;
                    break;
                case "g":
                    code = code | 2;
                    break;
                case "p":
                    code = code | 3;
                    break;
            }

            return code;
        }
    }
}