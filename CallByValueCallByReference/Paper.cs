namespace CallByValueCallByReference;

public struct Paper
{
    private int _timesPrinted;

    public int TimesPrinted
    {
        get { return _timesPrinted; }
        set { _timesPrinted = value; }
    }
}