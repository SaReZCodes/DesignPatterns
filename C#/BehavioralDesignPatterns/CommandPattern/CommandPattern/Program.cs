using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Receivers;

Light light = new Light();
Stereo stereo = new Stereo();

Invoker invoker = new Invoker();

invoker.SetCommand(new lightOnCommand(light));
invoker.ButtonWasPressed();


invoker.SetCommand(new StereoOnCDCommand(stereo));
invoker.ButtonWasPressed();