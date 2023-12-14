using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("11989982722", "Iphone 12 Pro MAX", "11111111", 500);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("11981337177", "Nokia 15", "2222222", 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
