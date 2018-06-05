using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerSpace
{
    class Rabbit: AnimalRunner
    {
        private int break_time;

        public Rabbit(int bs, int es)
        {
            this.base_Speed = bs;
            this.extra_Speed = es;
            this.rnd = new Random();
            this.break_time = 0;
        }

        public override int Step()
        {
            if (this.break_time == 0)
            {
                this.break_time = rnd.Next(1, 5);
                return base_Speed + rnd.Next(0, extra_Speed);
            }
            else
            {
                --this.break_time;
                return 0;
            }
        }
    }
}
