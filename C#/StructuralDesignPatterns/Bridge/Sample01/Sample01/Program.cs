using Sample01.Color;
using Sample01.Shape;

IColor red = new Red();
IColor yellow = new yellow();

Circle circleRed = new Circle(red);
circleRed.Draw();

Circle circleYYellow = new Circle(yellow);
circleYYellow.Draw();

Square squareRed = new Square(red);
squareRed.Draw();

Square squareYYellow = new Square(yellow);
squareYYellow.Draw();

Console.ReadKey();