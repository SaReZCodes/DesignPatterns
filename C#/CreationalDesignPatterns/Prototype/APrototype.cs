using System;

abstract class APrototype : ICloneable
{
    public string Name { get; set; }
    public string Family { get; set; }
    public Token Token { set; get; }
    public string Color { get; set; }
    public abstract object Clone();
    public abstract object ObjectMemberwiseClone();
}

class Token
{
    public string UserName { get; set; }
    public string Roles { get; set; }
}