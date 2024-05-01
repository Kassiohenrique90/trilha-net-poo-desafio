using DesafioPOO.Models;


Nokia nokia = new Nokia("123456789", "Nokia 4451","123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Bomberman");

Iphone iphone = new Iphone("98765", "Iphone 15 ProMax", "98765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
//Implementado...