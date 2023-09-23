using ObserverPattern;

var greenLed = new GreenLED();
var redLed = new RedLED();
var blueLed = new BlueLED();

var switchKey = new Switch();
switchKey.Attach(greenLed);
switchKey.Attach(redLed);
switchKey.Attach(blueLed);

switchKey.ChangeState = true;
Console.WriteLine();
Thread.Sleep(3000);
switchKey.ChangeState = false;