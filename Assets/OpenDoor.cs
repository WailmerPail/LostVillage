using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool isKeyAExisted;

    public bool isPlayerEnter;

    private bool _isOpen;

    private bool _openDoor;
    public float degree;

    public Transform anchor;
    // Start is called before the first frame update
    void Start()
    {
        _isOpen = false;
        _openDoor = false;
        isPlayerEnter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isKeyAExisted && isPlayerEnter && !_isOpen && !_openDoor)
        {
            Debug.Log("Opening Door");
            _isOpen = true;
        }
        if (_isOpen && transform.rotation.y > degree)
        {
            transform.RotateAround(anchor.position, Vector3.down, 3f);
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("Player enter region");
    // }
}
