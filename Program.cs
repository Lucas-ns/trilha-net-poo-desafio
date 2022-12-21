using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456", "modelo 1", "111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("654321", "modelo 2", "222222", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");