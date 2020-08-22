using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalDiamondGame
{
    class Context
    {
        private IBoxStrategy strategy;

        public Context(IBoxStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void executeStrategy()
        {
           strategy.doOperation();
        }
    }
}
