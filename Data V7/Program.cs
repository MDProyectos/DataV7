using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_V7
{
    class Program
    { 
        static string path = @"C:\Users\Mario David\Desktop\ejercicios\Data V7\";
        static UserSet userSet;
        static void Main(string[] args)
        {
            path += args[0] + ".txt";
            userSet =  new UserSet(path);
            MainMenu();
            Console.ReadKey();
        }
        public static void MainMenu()
        {
            
            Console.Clear();
            bool pass = true;
            Console.WriteLine("Elige la opcion que desea realizar");
            Console.WriteLine("1. Mostrar los registros");
            Console.WriteLine("2. Encontrar un registro");
            Console.WriteLine("3. Agregar un registro");
            Console.WriteLine("4. Salir");
            
            do{
                pass = true;
                string option = Console.ReadLine();
                option = option.ToLower();
                switch(option)
                {
                    case "1":
                        ShowRegisters();
                        break;
                    case "2":
                        FindRegister();
                        break;
                     case "3":
                        AddNewRegister();
                        break;
                    case "4":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        pass = false;
                        continue;
                }
            }while(!pass);

        }
        private static void FindRegister()
        {
            if (File.Exists(path)) 
            {  
                Console.Clear();
                Console.WriteLine("Pon la cedula del registro que deseas buscar");
                string cedula;
                do{
                    Console.Write("Escribe la cedula: ");
                    cedula = Read.ReadLong().ToString();
                }while(!Validate.ValidateCedula(cedula));
                Console.WriteLine();
                User u = userSet.GetUser(cedula);
                Console.WriteLine(u.cedula + "," + u.name+ "," + u.lastName+ "," + u.sex+ "," + u.age+ "," + u.civilStatus+ "," + u.grade);
                Console.WriteLine("1. Editar registro");
                Console.WriteLine("2. Borrar registro");
                Console.WriteLine("3. Salir");
                bool pass = true;
                do{
                pass = true;
                char option = Read.ReadChar("123");
                switch(option)
                {
                    case '1':
                        EditRegister(cedula);
                        break;
                    case '2':
                        DeleteRegister(cedula);
                        break;
                    case '3':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        pass = false;
                        continue;
                }
            }while(!pass);
            }
        }
         private static void ShowRegisters()
        {
            Console.Clear();
            List<User> users = userSet.AllUser();
            foreach(User u in users)
                Console.WriteLine(u.ToShow());
            Console.ReadKey();
            MainMenu();
        }
        private static void AddNewRegister()
        {
            Console.Clear();
            string register = "";
            
            bool pass = true;
            bool pass2 = true;
            string cedula,name,lastName,toCode,password;
            int age;
            decimal save;
            do{
                do{
                    Console.Write("Escribe la cedula: ");
                    cedula = Read.ReadLong().ToString();
                }while(!Validate.ValidateCedula(cedula));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu nombre:");
                    name = Read.ReadString();
                }while(!Validate.ValidateName(name));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu apellido:");
                    lastName = Read.ReadString();
                }while(!Validate.ValidateName(lastName));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu edad:");
                    age = Read.ReadInt();
                }while(!Validate.ValidateAge(age));
                Console.WriteLine();
                do{
                    Console.Write("Escibe lo que vas a ahorrar:");
                    save = Read.ReadDecimal();
                }while(!Validate.ValidateSaving(save));
                Console.WriteLine();
                toCode = "";
                Console.WriteLine("Sexo: M|F ");
                string option = Read.ReadChar("mf").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();

                Console.WriteLine("Estado Civil: S|C ");
                option = Read.ReadChar("sc").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();

                Console.WriteLine("Grado academico: I|M|G|P");
                option = Read.ReadChar("imgp").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();
                Console.WriteLine(toCode + "y" + age);
                do{
                    Console.Write("Escibe la contraseña:");
                    password = Read.ReadString("*");
                }while(!Validate.ValidatePassword(password));
                Console.WriteLine();
                register = cedula + "," + name + "," + lastName + "," + save + "," + password + "," + toCode + "," + age;

                pass = true;
                Console.WriteLine("Grabar(G), Continuar(C), Salir(S)?");
                do{
                    pass2 = true;
                    option = Read.ReadChar().ToString();
                    option = option.ToLower();
                    switch(option)
                    {
                        case "g":
                            break;
                        case "c":
                            pass = false;
                            break;
                        case "s":
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("La opcion no es valida");
                            pass2 = false;
                            continue;
                    }
                }while(!pass2);
            }while(!pass);
            string[] registers = register.Split(",");
            User user = new User(registers);
            userSet.AddUser(user);
            Console.WriteLine("Se ha guardado exitosamente.");
            MainMenu();
        }
        private static void EditRegister(string id)
        {
            Console.Clear();
            string register = "";
            
            bool pass = true;
            bool pass2 = true;
            string cedula,name,lastName,toCode,password;
            int age;
            decimal save;
            do{
                do{
                    Console.Write("Escribe la cedula: ");
                    cedula = Read.ReadLong().ToString();
                }while(!Validate.ValidateCedula(cedula));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu nombre:");
                    name = Read.ReadString();
                }while(!Validate.ValidateName(name));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu apellido:");
                    lastName = Read.ReadString();
                }while(!Validate.ValidateName(lastName));
                Console.WriteLine();
                do{
                    Console.Write("Escibe tu edad:");
                    age = Read.ReadInt();
                }while(!Validate.ValidateAge(age));
                Console.WriteLine();
                do{
                    Console.Write("Escibe lo que vas a ahorrar:");
                    save = Read.ReadDecimal();
                }while(!Validate.ValidateSaving(save));
                Console.WriteLine();
                toCode = "";
                Console.WriteLine("Sexo: M|F ");
                string option = Read.ReadChar("mf").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();

                Console.WriteLine("Estado Civil: S|C ");
                option = Read.ReadChar("sc").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();

                Console.WriteLine("Grado academico: I|M|G|P");
                option = Read.ReadChar("imgp").ToString();
                option = option.ToLower();
                toCode += option;
                Console.WriteLine();
                Console.WriteLine(toCode + "y" + age);
                do{
                    Console.Write("Escibe la contraseña:");
                    password = Read.ReadString("*");
                }while(!Validate.ValidatePassword(password));
                Console.WriteLine();
                register = cedula + "," + name + "," + lastName + "," + save + "," + password + "," + toCode + "," + age;

                pass = true;
                Console.WriteLine("Grabar(G), Continuar(C), Salir(S)?");
                do{
                    pass2 = true;
                    option = Read.ReadChar().ToString();
                    option = option.ToLower();
                    switch(option)
                    {
                        case "g":
                            break;
                        case "c":
                            pass = false;
                            break;
                        case "s":
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("La opcion no es valida");
                            pass2 = false;
                            continue;
                    }
                }while(!pass2);
            }while(!pass);
            string[] registers = register.Split(",");
            User user = new User(registers);
            userSet.EditUser(user,id);
            Console.WriteLine("Se ha editado exitosamente.");
            MainMenu();
        }
        private static void DeleteRegister(string id)
        {
            Console.Clear();
            userSet.Delete(id);
            Console.WriteLine("Se ha borrado exitosamente.");
            MainMenu();
        }
    }
}

