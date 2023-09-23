BASIC CODE : 

public class Originator
{
    private string _state;
 
    public Memento CreateMemento()
    {
        return new Memento(_state);
    }
 
    public void SetMemento(Memento memento)
    {
        _state = memento.GetState();
    }
}
 
 
public class Memento
{
    private string _state;
 
    public Memento(string state)
    {
        _state = state;
    }
 
    public string GetState()
    {
        return _state;
    }
}
 
 
public class Caretaker
{
    public Memento Memento { get; set; }
}