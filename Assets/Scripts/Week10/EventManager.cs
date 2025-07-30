using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public delegate void PlatformDelegate();

    public static PlatformDelegate onSpacePressed;
}
