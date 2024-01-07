using Celular.models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456",modelo: "Modelo 1 ",imei: "11111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");   

Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4987",modelo: "Modelo 2 ",imei: "22222222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");




