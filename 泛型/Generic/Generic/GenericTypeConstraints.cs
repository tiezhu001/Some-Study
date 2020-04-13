using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericTypeConstraints
    {

    }

    // 1.引用类型约束
    public class classSample<T> where T : class
    {

    }

    // 2.值类型约束
    public class structSample<T> where T : struct
    {

    }

}
