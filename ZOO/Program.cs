using ZOO;

Aviary[] stock = new Aviary[4];

stock[0] = new Aviary("MirrorLake", "lake", 65);
stock[1] = new Aviary("Africa", "savannah", 120);
stock[2] = new Aviary("Tall tree", "lake", 15);
stock[3] = new Aviary("Hunting grounds", "savannah", 320);

AbstractAnimal[] zoo = new AbstractAnimal[4];

zoo[0] = new DuckAnimal("", 3, 5);
zoo[1] = new RatelAnimal("", 6, 12);
zoo[2] = new StorkAnimal("", 4, 8);
zoo[3] = new TurtleAnimal("", 127, 35);