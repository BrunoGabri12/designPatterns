// Para avançar no estudo, estou seguindo o livro Quebrando a Cabeça, ed.2 

using strategy.Models;

Duck duck = new MallardDuck();

duck.PerfomrQuack();
duck.PerformFly();



duck.DefineFlyComportament(new NoFly());
duck.DefineQuackComportament(new Squash());

duck.PerfomrQuack();
duck.PerformFly();