using ZOO;

IchthyosaurAnimal ichthyosaur = new IchthyosaurAnimal("Ancient", 1230, 4000);

RatelAnimal ratel = new RatelAnimal("Miha", 3, 40);

StorkAnimal stork = new StorkAnimal("Jon Smith", 4, 55);

DuckAnimal duck = new DuckAnimal("Evil", 2, 35);

ichthyosaur.Swim(4);
ratel.Hunt(5);
stork.Fly(7);

Console.WriteLine();
ichthyosaur.DoEat("Sun", 9999999);
ratel.DoEat("meat", 2);
stork.DoEat("frog", 1);

Console.WriteLine();
ratel.WillPlay(stork, ratel);
stork.WillPlay(stork, duck);

Console.WriteLine();
ichthyosaur.AnimalStatus();
ratel.AnimalStatus();
stork.AnimalStatus();
duck.AnimalStatus();