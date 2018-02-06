using System;

namespace AmIOffended.Core.Offensive
{
    internal class Shrink : IShrink
    {
        public OffendedState AmIOffended()
        {
            Random random = new Random(DateTime.UtcNow.Millisecond);
            if (random.Next(100) > 42) return OffendedState.Offended;
            if (random.Next(100) == 42) return OffendedState.VeryOffended;
            return OffendedState.NotOffended;
        }
    }
}
