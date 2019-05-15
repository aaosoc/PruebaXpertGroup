using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpertGroup.Utils.Helpers
{
    public class ProcessOperationsCubeSum: IProcessOperationsCubeSum
    {
        public int dimensions { get; set; }

        int[,,] tree;
        int[,,] nums;


        public void CreateMatrix(int dimensions)
        {
            if (dimensions == 0) return;
            this.dimensions = dimensions;
            tree = new int[dimensions + 1, dimensions + 1, dimensions + 1];
            nums = new int[dimensions, dimensions, dimensions];
        }


        public void OperationUpdate(int x, int y, int z, int value)
        {
            int delta = value - nums[x, y, z];
            nums[x, y, z] = value;
            for (int i = x + 1; i <= dimensions; i += i & (-i))
            {
                for (int j = y + 1; j <= dimensions; j += j & (-j))
                {
                    for (int k = z + 1; k <= dimensions; k += k & (-k))
                    {
                        tree[i, j, k] += delta;
                    }
                }
            }
        }

        public int OperationQuery(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            int result = GetSumCube(x2 + 1, y2 + 1, z2 + 1) - GetSumCube(x1, y1, z1) - GetSumCube(x1, y2 + 1, z2 + 1) - GetSumCube(x2 + 1, y1, z2 + 1) - GetSumCube(x2 + 1, y2 + 1, z1) + GetSumCube(x1, y1, z2 + 1) + GetSumCube(x1, y2 + 1, z1) + GetSumCube(x2 + 1, y1, z1);
            return result;
        }

        private int GetSumCube(int x, int y, int z)
        {
            int sum = 0;
            for (int i = x; i > 0; i -= i & (-i))
            {
                for (int j = y; j > 0; j -= j & (-j))
                {
                    for (int k = z; k > 0; k -= k & (-k))
                    {
                        sum += tree[i, j, k];
                    }
                }
            }
            return sum;
        }
    }
}
