using demo_oop_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_5
{
    internal abstract class shape
    {
        public decimal dimo01 { get; set; } 
        public decimal dimo02 { get; set; }
        public abstract decimal calcarea();
      

        public abstract decimal perimeter { get; }

    }
}

abstract class recbase :shape
{

    public override decimal calcarea()
    {
        return dimo01 + dimo02;
    }

}

class rectangle : recbase
{
    public override decimal perimeter
    { 
    get { return (dimo01 + dimo02) * 2; }
    }

    public override decimal calcarea()
    {
        return dimo01 + dimo02; 
    }
}
 

class square : recbase
{
    public square(decimal dim)
    {
        dimo01 = dimo02 = dim;
    }
    public override decimal perimeter => dimo01 * 4;

    public override decimal calcarea()
    {
        return dimo01 + dimo02;
    }
}
class circle : shape
{
    public circle(decimal redius)
    {
        dimo01 = dimo02 = redius;
    }
    public override decimal perimeter => 2 * 3.14m * dimo01;

    public override decimal calcarea()
    {
        return 3.14m * dimo01 * dimo02;
    }
}
