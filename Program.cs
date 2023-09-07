using ChallengeOOP.Models;

Console.WriteLine("Nokia Smartphone: ");
Smartphone nokia = new Nokia(number: "654321", model: "Nokia 5.4", imei: "222222222222222", memory: 128);
nokia.TurnOn();
nokia.InstallApplication("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("iPhone Smartphone: ");
Smartphone iphone = new Iphone(number: "123456", model: "iPhone 8 Plus", imei: "111111111111111", memory: 256);
iphone.ReceiveCall();
iphone.InstallApplication("Telegram");
