using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("1100","222222222222222", 64);
nokia.Ligar("81 988888888");
nokia.ReceberLigacao("81 988888888");
nokia.InstalarAplicativo("81 988888888", "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone ("13","333333333333333", 128);
iphone.Ligar("");
iphone.ReceberLigacao("");
iphone.InstalarAplicativo("","Telegram");