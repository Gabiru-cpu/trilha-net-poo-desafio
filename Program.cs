using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123999", modelo: "Modelo 1", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "1288", modelo: "Modelo 2", imei: "987654321", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DioApp");