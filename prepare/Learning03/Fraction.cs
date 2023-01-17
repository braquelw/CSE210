class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string integers = $"{_top}/{_bottom}";
        return integers;
    }
    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        double decimalvalue = top/bottom;
        return decimalvalue;
    }
}