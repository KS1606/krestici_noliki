using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace магазин
{
    internal interface ICrud
    {
        void Create();
        void Read();
        void Update();
        void Delete();

    }
}
