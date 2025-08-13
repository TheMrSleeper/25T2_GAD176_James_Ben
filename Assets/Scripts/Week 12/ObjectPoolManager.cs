using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager Instance;

    public Platform platformPrefab;
    public int poolsize = 50;

    private List<Platform> platformPool;

    private void Awake()
    {
        Instance = this;
        IntitPlatformPool();
    }

    void IntitPlatformPool()
    {
        platformPool = new List<Platform>();

        for (int i = 0; i < poolsize; i++)
        {
            Platform platform = Instantiate(platformPrefab);
            platform.gameObject.SetActive(false);
            platformPool.Add(platform);
        }
    }

    public Platform GetPooledPlatform()
    {
        foreach (var platform in platformPool)
            if (!platform.gameObject.activeInHierarchy)
            {
                return platform;
            }

        Platform newPLatform = Instantiate(platformPrefab);
        newPLatform.gameObject.SetActive(false);
        platformPool.Add(newPLatform);

        return null;
    }
}
