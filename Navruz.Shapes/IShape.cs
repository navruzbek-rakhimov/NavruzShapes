using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navruz.Shapes
{
    public interface IShape
    {
        public double GetArea();
    }
}

// 1. Area of Circle - R
// 2. Area of Triangle - A, B, C
// 3. Ease of adding new shapes
// 4. Area without knowing type of shape
// 5. Is Triangle Right
// 6. Unit-Tests