using MediatorPatternSample2;
ConcrateColleague m = new ConcrateColleague();


Colleague c1 = new ConcrateColleague1(m);
Colleague c2 = new ConcrateColleague2(m);

m.Colleague1= c1;
m.Colleague2= c2;

m.SendMessage("Hi Message Send To : ", c1);
m.SendMessage("Hi Message Send To : ", c2);