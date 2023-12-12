namespace DZ
{
    public interface IQuest
    {
        string GetResult();
    }


    class Adapteer
    {
        public string GetNewResult()
        {
            return "Нове завдання";
        }
    }

    class Adapter : IQuest
    {
        private readonly Adapteer adap;

        public Adapter(Adapteer adaptee)
        {
            this.adap = adaptee;
        }

        public string GetResult()
        {
            return $"Це '{this.adap.GetNewResult()}'";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adapteer adap = new Adapteer();
            IQuest q = new Adapter(adap);


            Console.WriteLine(q.GetResult());
        }
    }
}