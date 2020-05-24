using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    private bool ifKey = false;
    private JointMotor joint;
    // Start is called before the first frame update
    void Start()
    {
        joint.force = 10;

    }

    // Update is called once per frame
    void Update()
    {
        if (ifKey) { OpenDoor(); }
    }
    void OpenDoor()
    {
        if (ifKey)
        {
            joint.targetVelocity = -30;
        }
        else
        {
            joint.targetVelocity = 30;
        }
        gameObject.GetComponent<HingeJoint>().motor = joint;
    }
}
