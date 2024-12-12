using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatN : Cat
{
    private int k;

    public int GetK() => k;

    public CatN(string name) : base(name)
    {
        this.k = 0;
    }

    public void Meow(int? n = null)
    {
        base.Meow(n);
        if (n is null || n == 0)
            k++;
        else
            k += (int)n;
    }
}
