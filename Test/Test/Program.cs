using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static string FullName = "", YearBirth = "", FaivoritProg = "", ExpInProg = "", NumberPhone = "";
        public static string TextLine = "";
        public static int Pro = 0;
        public static bool endApp = false;
        public static ArrayList s2 = new ArrayList();


        static void Main(string[] args)
        {
            Help();
            Console.WriteLine("Строка ввода--------->");
            while (!endApp)
            {
                string m = Console.ReadLine();
                
                if (m.Contains("help") == true)
                {
                    Help();
                }
                if (m.Contains("new_profile") == true)
                {
                    NewProfile();
                }
                if (m.Contains("find") == true)
                {
                    serching(m);
                }
                if (m.Contains("exit") == true)
                {
                    endApp = true;
                }
                if (m.Contains("delete") == true)
                {
                    string s = m.Replace("delete", " ");
                    s = s.Trim();
                    File.Delete($"save/{s}.txt");
                }
                if (m.Contains("list") == true)
                {
                    Catalog();
                    for(int i = 0; i<s2.Count; i++)
                    {
                        Console.WriteLine(s2[i]);
                    }
                }
                Console.WriteLine("\n"); // Friendly linespacing.
                Console.WriteLine("Строка ввода--------->");
            }
            return;           
        }
        static void Help()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("-new_profile - Заполнить новую анкету");
            Console.WriteLine("-save - Сохранить заполненную анкету");
            Console.WriteLine("-goto_question <Номер вопроса> - Вернуться к указанному вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос) ");
            Console.WriteLine("-goto_prev_question - Вернуться к предыдущему вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)");            
            Console.WriteLine("-find <Имя файла анкеты> - Найти анкету и показать данные анкеты в консоль");
            Console.WriteLine("-delete <Имя файла анкеты> - Удалить указанную анкету");
            Console.WriteLine("-list - Показать список названий файлов всех сохранённых анкет");
            Console.WriteLine("-help - Показать список доступных команд с описанием");
            Console.WriteLine("-exit - Выйти из приложения");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
        }
        static void NewProfile()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("В анкете 5 вопросов:");
            Console.WriteLine("1. ФИО;");
            Console.WriteLine("2. Дата рождения (Формат ДД.ММ.ГГГГ);");
            Console.WriteLine("3. Любимый язык программирования (Можно ввести только указанные варианты, иначе ошибка: PHP, JavaScript, C, C++, Java, C#, Python, Ruby);");
            Console.WriteLine("4. Опыт программирования на указанном языке (Полных лет);");
            Console.WriteLine("5. Мобильный телефон.");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            while(Pro < 6)
            {
                Text();
                if(TextLine.Contains("restart_profile") == true)
                {
                    Pro = 0;
                }
                if(TextLine.Contains("goto_question") == true)
                {
                    if(TextLine.Contains("1") == true)
                    {
                        Pro = 0;
                    }
                    if (TextLine.Contains("2") == true)
                    {
                        Pro = 1;
                    }
                    if (TextLine.Contains("3") == true)
                    {
                        Pro = 2;
                    }
                    if (TextLine.Contains("4") == true)
                    {
                        Pro = 3;
                    }
                    if (TextLine.Contains("5") == true)
                    {
                        Pro = 4;
                    }
                }
                if (TextLine.Contains("save") == true && Pro == 5)
                {
                    save();
                }
                if (TextLine.Contains("goto_prev_question") == true && Pro != 0)
                {
                    Pro = Pro - 2;
                }
                if (Pro == 0)
                {
                    name(TextLine);
                }
                if (Pro == 1)
                {
                    Year(TextLine);
                }
                if (Pro == 2)
                {
                    Faivorit(TextLine);
                }
                if (Pro == 3)
                {
                    EXP(TextLine);
                }
                if (Pro == 4)
                {
                    Phone(TextLine);
                }
                
                Pro++;
            }
        }
        static void Text()
        {
            
            if (Pro == 0)
            {
                Console.WriteLine("Введите ФИО:");
            }
            if (Pro == 1)
            {
                Console.WriteLine("Дата рождения (Формат ДД.ММ.ГГГГ):");
            }
            if (Pro == 2)
            {
                Console.WriteLine("Любимый язык программирования (Можно ввести только указанные варианты, иначе ошибка: PHP, JavaScript, C, C++, Java, C#, Python, Ruby):");
            }
            if (Pro == 3)
            {
                Console.WriteLine("Опыт программирования на указанном языке (Полных лет):");
            }
            if (Pro == 4)
            {
                Console.WriteLine("Мобильный телефон:");
            }
            if (Pro == 5)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Введите одну из следующих команд:");
                Console.WriteLine("-new_profile - Заполнить новую анкету;");
                Console.WriteLine("-save - Сохранить заполненную анкету;");
                Console.WriteLine("-goto_question <Номер вопроса> - Вернуться к указанному вопросу;");
                Console.WriteLine("-goto_prev_question - Вернуться к предыдущему вопросу.");
                Console.WriteLine("----------------------");
            }
            TextLine = Console.ReadLine().Trim();
            if (TextLine == "")
            {
                Text();
            }         
        }
        static void name(string s)
        {
            string h = s;
            FullName = h;
            if (FullName == "")
            {
                name(h);               
            }      
        }
        static void Year(string s)
        {
            string h = s;           
            YearBirth = h;
            if (YearBirth == "")
            {
                Year(h);
            }           
        }
        static void Faivorit(string s)
        {
            int i = 0;
            string h = s;
            string[] l= { "PHP", "JavaScript", "C", "C++", "Java", "C#", "Python", "Ruby" };
            foreach(string j in l)
            {
                if(j == h)
                {
                    i++;
                }
            }
            if(i == 0)
            {
                Pro = Pro - 1;
            }
            FaivoritProg = h;
                    
        }
        static void EXP(string s)
        {
            string h = s;        
            ExpInProg = h;
            if (ExpInProg == "")
            {
                EXP(h);
            }
        }
        static void Phone(string s)
        {
            string h = s;          
            NumberPhone = h;
            if (NumberPhone == "")
            {
                Phone(h);
            }
        }
        static void Catalog()
        {
            s2.Clear();
            string g = "";
            string[] allfiles = Directory.GetFiles("save/");
            foreach (string filename in allfiles)
            {
                g = filename.Replace("save/", " ");
                g = g.Replace(".txt", " ");
                g = g.Trim();
                s2.Add(g);
            }
        }
        static void serching(string s)
        {
            Catalog();
            string g = "";
            g = s.Replace("find", " ");
            g = g.Trim();          
            if (s2.Contains(g) == true)
            {
                using (StreamReader sr = new StreamReader($"save/{g}.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено. Попробуйте снова.");
            }                        
        }
        static void save()
        {
            if (FullName != "" && YearBirth != "" && FaivoritProg != "" && ExpInProg != "" && NumberPhone != "")
            {
                StreamWriter sw = new StreamWriter($"save/{FullName}.txt");
                sw.WriteLine($"ФИО: {FullName}");
                sw.WriteLine($"Дата рождения: { YearBirth}");
                sw.WriteLine($"Язык программирования: {FaivoritProg}");
                sw.WriteLine($"Опыт программирования: {ExpInProg} лет");
                sw.WriteLine($"Номер телефона: {NumberPhone}");
                sw.WriteLine($"Профиль заполнен: {DateTime.Now}");
                sw.Close();
                Console.WriteLine("Профиль сохранён в папке с программой--->save/'ФИО профиля'");
            }
            else
            {
                Console.WriteLine("Записей нет, либо вы заполнили анкету не полностью. Попробуйте снова.");
            }
        }
    }
}
