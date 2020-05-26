using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObserver : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            Debug.Log("Player enter");
            gameObject.GetComponentInParent<OpenDoor>().isPlayerEnter = true;
        }
        
    }
}
