using System;

public class Test
{

    public int Mid;
    public int Final;

    public Test(int m, int f)
    {
        this.Mid= Mid; 
        this.Final = Final;
    }
    
    public void SetMid(int value)
    {
        this.Mid = Mid;
    }

    public void SetFinal(int value)
    {
        this.Final = Final;
    }

    public int GetMid()
    {
        return this.Mid;
    }

    public int GetFinal()
    {
        return this.Final;
    }
    
    public double GetAvg()
    {
        return (Mid+Final)/2.0;
    }
}
