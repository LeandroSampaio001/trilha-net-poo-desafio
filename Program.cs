using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo-1", imei: "123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Nokia(numero: "4987", modelo: "Modelo-2", imei: "321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
