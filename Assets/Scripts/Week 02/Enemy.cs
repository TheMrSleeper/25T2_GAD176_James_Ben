using System.Collections;
using System.Collections.Generic;
using StabbyStuff.Player;
using UnityEngine;

namespace StabbyStuff.BadGuys
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int health;
        [SerializeField] private int maxHealth = 100;

        [SerializeField] private Inventory inventory;

        void Start()
        {
            health = maxHealth;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                inventory.StabEnemy();
            }
        }

        public void DamageHealth(int damage)
        {
           health -= damage;
        }
    }
}
