using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("1100","222222222222222", 64);
nokia.Ligar("81 98888-8888");
nokia.ReceberLigacao("81 98888-8888");
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone ("13","333333333333333", 128);
iphone.Ligar("");
iphone.ReceberLigacao("");
iphone.InstalarAplicativo("Telegram");