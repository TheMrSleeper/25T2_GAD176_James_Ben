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

        [SerializeField] private Item[] items; 

        public void StabEnemy()
        {
            knives[0].Stab();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (items[0] != null)
                {
                    Debug.Log("Item in the first slot is " + items[0].itemName);
                }
            }
        }
    }
}
