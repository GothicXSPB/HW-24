using ZOO;

Animal animal = new Animal("Медоед",12,44);
Animal animal1 = new Animal("Димон",1,1);
Animal animal2 = new Animal("Креветочная батарея",44,97);


animal.Play(12);
animal2.DoEat("fish",3);
animal1.DoEat("греча",100);
animal.DoSound();