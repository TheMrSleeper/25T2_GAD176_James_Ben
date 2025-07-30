using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.onSpacePressed += HideThePlatform;
        EventManager.onSpacePressed -= ShowThePlatform;
    }

    private void OnDisable()
    {
        EventManager.onSpacePressed -= HideThePlatform;
        EventManager.onSpacePressed += ShowThePlatform;
    }

    private void HideThePlatform()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void ShowThePlatform()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
