using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("1234567890", "Iphone 13", "IMEI1234567890", 128);
Smartphone nokia = new Iphone("0987654321", "Nokia 3310", "IMEI0987654321", 64);

Console.WriteLine("Testando o Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Testando Nokia: ");
nokia.Ligar();  
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.ReadLine();