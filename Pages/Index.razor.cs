namespace CairoMetro.Pages;
public partial class Index
{
    Station? CurrentStatin { get; set; }
    bool clicked = false;
    void Click(Station item) => (CurrentStatin, clicked) = CurrentStatin != item ? (item, true) : (CurrentStatin, !clicked);
    void MouseOver(Station item) => CurrentStatin = clicked ? CurrentStatin : item;
    void MouseOut() => CurrentStatin = clicked ? CurrentStatin : null;
}