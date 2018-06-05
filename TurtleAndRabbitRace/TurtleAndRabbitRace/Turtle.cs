using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerSpace
{
    class Turtle:AnimalRunner
    {
        public Turtle(int bs, int es)
        {
            this.base_Speed = bs;
            this.extra_Speed = es;
            this.rnd = new Random();
        }
    }
}
