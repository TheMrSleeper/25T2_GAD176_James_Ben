using System.Collections;
using System.Collections.Generic;
using StabbyStuff.BadGuys;
using UnityEngine;

namespace StabbyStuff.Weapons
{
    public class Knife : MonoBehaviour, ICollectable, ICraftable
    {
        // Properties
        // Has a damage amount
        [SerializeField] private int damage;
        // Has an attack spead
        [SerializeField] private float cooldown;
        // Has an attack range
        [SerializeField] private float reach;


        // Functionality
        // Can be attacked with
        public void Stab()
        {
            Debug.Log("Enemy Stabbed with " +gameObject.name);
        }
        // Can be picked up
        public void Collect()
        {
            // Output to console that knife has been collected
            Debug.Log("You have collected a new knife!");
        }

        public void Craft()
        {
            // Output crafting process to console
            Debug.Log("You crafted a knife");
            Collect();
        }

        public bool IsCraftable()
        {
            return true;
        }
        // Can be dropped
    }
}
