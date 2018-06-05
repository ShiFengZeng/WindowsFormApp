using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerSpace
{
    class AnimalRunner
    {
        protected int base_Speed;
        protected int extra_Speed;
        protected Random rnd;

        public virtual int Step()
        {
            return base_Speed + rnd.Next(0, extra_Speed);
        }
    }
}
