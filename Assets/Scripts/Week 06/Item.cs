using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StabbyStuff
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]

    public class Item : ScriptableObject
    {
        public string itemName;
        public int itemID;
        public float quality;
    }
}
