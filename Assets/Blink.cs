using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public int blinkInterval = 10;
    private int _frameCount;
    private void Start()
    {
    
        var _frameCount = 0;
    }
    
    private void Update()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
        if (_frameCount == blinkInterval)
        {
            halo.enabled = true;
            _frameCount = 0;
        }
        else
        {
            halo.enabled = false;
            _frameCount += 1;
        }
    }
}
