public interface IBuilder
{
    void BuildOs(); 
    void BuildScreen();
    Phone Phone { get; }
}