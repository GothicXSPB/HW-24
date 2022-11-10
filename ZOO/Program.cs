using ZOO;


IchthyosaurAnimal ichthyosaur = new IchthyosaurAnimal("Ancient", 1230, 4000);

RatelAnimal ratel = new RatelAnimal("Михалыч", 3, 40);

StorkAnimal stork = new StorkAnimal("Сан Саныч", 4, 55);


ichthyosaur.Swimming(4);
ratel.Hunt(5);
stork.Fly(7);

Console.WriteLine();
ichthyosaur.DoEat("солнце", 9999999);
ratel.DoEat("meat", 2);
stork.DoEat("frog", 1);