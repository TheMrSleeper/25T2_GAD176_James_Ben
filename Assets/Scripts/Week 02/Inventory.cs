using System.Collections;
using System.Collections.Generic;
using StabbyStuff.Weapons;
using Unity.VisualScripting;
using UnityEngine;

namespace StabbyStuff.Player
{
    public class Inventory : MonoBehaviour
    {
        // Contains collection of items
        [SerializeField] private Knife[] knives;

        public void StabEnemy()
        {
            knives[0].Stab();
        }
    }
}
