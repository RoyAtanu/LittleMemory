using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleMemory.Core
{
    public sealed class LittleMemory
    {
        private static readonly Lazy<LittleMemory> lazy = new Lazy<LittleMemory>(() => new LittleMemory());

        public static LittleMemory Instance { get { return lazy.Value; } }

        private LittleMemory()
        {

        }
    }
}
