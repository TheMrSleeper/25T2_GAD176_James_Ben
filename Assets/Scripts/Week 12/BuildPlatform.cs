using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BuildPlatform : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Platform retrievedPlatform = ObjectPoolManager.Instance.GetPooledPlatform();

            Debug.Log("Look at that platform.");
            retrievedPlatform.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-8, 8), Random.Range(-8, 8));
            retrievedPlatform.gameObject.SetActive(true);
        }
    }
}
