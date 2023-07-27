using Aula14Objetos;

Console.WriteLine("Hello, World!");


//=========================== P1 ========================================
Pessoa p1 = new Pessoa("MK", 22, "Santa Cruz", "Centro", "São carlos"); //Por usar o método do construtor, o [new pessoa] pede parametro, que é oque está dentro dos parenteses "MK", 22 == nome e idade
p1.mostra();//Ele n vai confundir o mostra, porque estanciamos logo acima (Pessoa p1)
p1.endereco.mostra(); //o endereco tem que ser minusculo porque se for Mai ele chama a classe inteira (pg) em vez da variavel

Console.ReadKey();