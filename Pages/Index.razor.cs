namespace CairoMetro.Pages;
public partial class Index
{
    Station? CurrentStatin { get; set; }

    bool clicked = false;
    void Click(Station item) => (CurrentStatin, clicked) = CurrentStatin != item ? (item, true) : (CurrentStatin, !clicked);
    void MouseOver(MouseEventArgs e, Station item) => CurrentStatin = clicked ? CurrentStatin : item;
    void MouseOut(MouseEventArgs e) => CurrentStatin = clicked ? CurrentStatin : null;
}