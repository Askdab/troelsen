using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    public class Stringis
    {
        public void CheckPassword()
        {
            Console.WriteLine("Введите ваш логин");
            string login = Console.ReadLine();
            if (login.Contains("nigger"))
            {
                Console.WriteLine("Балять НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Н-СЛОВО ПИДАРАС ТЫ БЛЯТЬ БЛЕК ЛИВС МЕТТЕР НАХУЙ");
                login = "banned";
                Console.WriteLine("Вы забанены! {0}", login);
            }
            else 
            { 
                Console.WriteLine("Ладно"); 
            }

            Console.WriteLine("Введите ваш пароль!");
            string pass = Console.ReadLine();
            Console.WriteLine("Повторите пароль!");
            string actpass = Console.ReadLine();
            if (pass.Equals(actpass))
            {
                Console.WriteLine("Проходите дальше!");
            }
            else
            {
                Console.WriteLine("Пароли не совпадают!");
                Console.WriteLine("{0}", pass.Equals(actpass));
            }

            string del = login.Trim('*');
            del = del.ToLower();
            Console.WriteLine(del.ToUpper());

            string[] empt = del.Split(' ');
            foreach(var sub in empt)
            {
                Console.WriteLine($"разделенный логин {sub}");
            }

            Console.WriteLine("Добавим символы к логину: {0}", del.Replace("dy", "hui"));
            Console.WriteLine("Удалим первые два символа: {0}", del.Remove(0, 2));

            Console.WriteLine("\a{0}" + "{1}", del, pass);

            string myLongString = @"This is а ""very                  \a
                                                        very
                                                    very""
                                    long string ";
            Console.WriteLine(myLongString);

            Console.WriteLine("login == password {0}", del == pass);
        }

        public void StringisBuilder()
        {
            int hui = 10;
            StringBuilder sb = new StringBuilder("Пробуем стринг билдер");
            Console.WriteLine(sb);
            string greeting = $"Pidor {sb} zalupa {hui}";
            Console.WriteLine(greeting);
        }
    }
}
