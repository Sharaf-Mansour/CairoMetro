namespace CairoMetro.Model;
public record Station(int ID, string Name, Line Line, string Style, bool IsSwitch = false);
public enum Line
{
    Line1,
    Line2,
    Line3,
}