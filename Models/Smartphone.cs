namespace ChallengeOOP.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string Imei { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving a call...");
        }

        public abstract void InstallApplication(string appName);
    }
}
