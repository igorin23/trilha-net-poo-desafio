using DesafioPOO.Models;

Smartphone N1 = new Nokia ("995521822", "ss2", "123", 68);
Smartphone I1 = new Iphone ("91054436", "15", "452", 128);

Console.WriteLine("Nokia:");
N1.Ligar();
N1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
I1.ReceberLigacao();
I1.InstalarAplicativo("Whatsapp");
// TODO: Realizar os testes com as classes Nokia e Iphone