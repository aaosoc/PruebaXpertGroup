using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpertGroup.Utils.Helpers
{
    public interface IProcessOperationsCubeSum
    {
        void CreateMatrix(int dimensions);
        void OperationUpdate(int x, int y, int z, int value);
        int OperationQuery(int x1, int y1, int z1, int x2, int y2, int z2);
    }

}
