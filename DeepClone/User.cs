using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepClone
{
    [Serializable]
    class User : ICloneable
    {
        public string Name { get; set; }
        public ArrayList albumIds = new ArrayList();

        public object Clone()
        {
            return Cloner.DeepClone(this);
        }
    }
}
