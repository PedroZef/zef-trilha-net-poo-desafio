using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "9472456", modelo: "Modelo 1", imei: "00000000", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "7834", modelo: "Modelo 2", imei: "4876555", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");