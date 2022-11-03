using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Smartphone Iphone = new Iphone(numero: "(11)4723-5676", modelo: "8 Plus", imei: "000000000", memoria: 132);
Iphone.Ligar();
Iphone.InstalarAplicativo("FaceBook");

Console.WriteLine("-------------------------------------");

Console.WriteLine("Nokia");
Smartphone Nokia = new Iphone(numero: "(11)4718-000", modelo: "Nokia 2.4", imei: "1001010010", memoria: 32);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo(" DuoLingo");
