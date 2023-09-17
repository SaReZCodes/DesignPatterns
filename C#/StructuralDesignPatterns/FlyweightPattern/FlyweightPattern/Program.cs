using FlyweightPattern;

var shapeFactory = new ShapeFactory();

var redShape = (Circle)shapeFactory.GetShape();
redShape.Color = "Red";
redShape.Draw();

var blueShape = (Circle)shapeFactory.GetShape();
blueShape.Color = "Blue";
blueShape.Draw();

