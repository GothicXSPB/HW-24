using ZOO;

Aviary[] stock = new Aviary[4];

stock[0] = new Aviary("lake", 65);
stock[1] = new Aviary("savannah", 120);
stock[2] = new Aviary("lake", 15);
stock[3] = new Aviary("savannah", 320);

AbstractAnimal[] zoo = new AbstractAnimal[4];

zoo[0] = new DuckAnimal("Steve", 3, 5);
zoo[1] = new RatelAnimal("Jon", 6, 12);
zoo[2] = new StorkAnimal("Dan", 4, 8);
zoo[3] = new TurtleAnimal("Anna", 127, 35);

stock[0].AddAnimalInAviary(zoo[2]);
stock[0].AddAnimalInAviary(zoo[1]);
stock[0].AddAnimalInAviary(zoo[0]);