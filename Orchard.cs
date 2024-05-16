namespace Orchard;

public class Orchard
{
    private int _length;
    private int _width;
    private string _plant;
    private int _yieldMax;
    private int _yieldMin;
    
    public Orchard(int length, int width, string plant, int yieldMax, int yieldMin)
    {
        _length = length;
        _width = width;
        _plant = plant;
        _yieldMax = Math.Max(yieldMax, yieldMin);
        _yieldMin = Math.Min(yieldMax, yieldMin);
    }

    public int Harvest()
    {
        Random rand = new Random();
        int yield = rand.Next(_yieldMin, _yieldMax + 1);
        return yield * _length * _width;
    }

    public int Length => _length;
    public int Width => _width;
    public string Plant => _plant;
    public int YieldMax => _yieldMax;
    public int YieldMin => _yieldMin;
}