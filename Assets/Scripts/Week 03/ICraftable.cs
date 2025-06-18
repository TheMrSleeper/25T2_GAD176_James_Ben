using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StabbyStuff
{
    public interface ICraftable
    {
        void Craft();
        bool IsCraftable();
    }
}
