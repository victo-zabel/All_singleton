public class Singleton
{
    // Статическое поле для хранения единственного экземпляра
    private static Singleton _instance;

    // Объект для синхронизации при многопоточном доступе
    private static readonly object _lock = new object();

    // Приватный конструктор, чтобы предотвратить создание экземпляров извне
    private Singleton()
    {
    }

    // Публичный метод для получения экземпляра класса
    public static Singleton Instance
    {
        get
        {
            // Используем блокировку для обеспечения потокобезопасности
            lock (_lock)
            {
                // Если экземпляр еще не создан, создаем его
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    // Пример метода класса
    public void SomeMethod()
    {
        Console.WriteLine("Метод Singleton вызван!");
    }
}
