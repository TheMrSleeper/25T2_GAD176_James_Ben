using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StabbyStuff.Weapons
{
    public class Player : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<ICraftable>() != null)
            {
                Debug.Log("You have found enough materials to craft a knife!");

                other.GetComponent<ICraftable>().Craft();
            }
        }
    }
}
