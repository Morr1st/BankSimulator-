using System.Linq;

namespace BankSimulator
{
    internal class Program
    {
        static List<Human> human = new List<Human>();
        static void Main(string[] args)
        {
            TryAddHuman(human, 1, "Максим", 1000);
            Started();   
            string command = Console.ReadLine();
            switch (command)
            {
                case "/поиск":
                    Console.WriteLine("Введите имя пользователя");
                    string userName = Console.ReadLine();
                    if (userName.Length > 0) { var searchName = human.Where(h => h.Name == userName); 
                    foreach (Human h in searchName)
                        {
                            Console.WriteLine(h.Id + " " + h.Name);
                        }
                    }
                    else { Console.WriteLine("Вы ввели пустое поле"); }
                    break;
                default:
                    Console.WriteLine("Я нихуя тебя не понимаю");
                    break;
            }
        }
        static string Started()
        {
            return "Добро пожаловть в БАНК СИМУЛЯТОР";
        }

        static void TryAddHuman(List<Human> human, int id, string name, decimal balance)
        {
            try
            {
                human.Add(new Human(id, name, balance));
            }
            catch { Console.WriteLine("Не удалось добавить пользователя"); }
        }
    }

    class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public User(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        virtual public string infoAboutUser()
        {
            return $"";
        }
    }

    class Admin : User 
    {
        public Admin(int id, string name, decimal balance) : 
            base(id ,name, balance) 
        { 
        
        }

        override public string infoAboutUser()
        {
            return base.infoAboutUser() + "";
        }
    }

    class Human : User
    {
        public Human(int id, string name, decimal balance) :
            base(id, name, balance)
        {

        }

        override public string infoAboutUser()
        {
            return base.infoAboutUser() + "";
        }
    }
}
