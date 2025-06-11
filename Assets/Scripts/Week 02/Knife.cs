using System.Collections;
using System.Collections.Generic;
using StabbyStuff.BadGuys;
using UnityEngine;

namespace StabbyStuff.Weapons
{
    public class Knife : MonoBehaviour
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
        // Can be dropped
    }
}
