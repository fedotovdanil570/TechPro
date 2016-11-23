using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSea
{
    [Serializable]
    class Pont
    {
        private int X;
        private int Y;
        private bool State;

        public Pont(int X, int Y, bool State)
        {
            this.X = X;
            this.Y = Y;
            this.State = State;
        }
    }
}
