using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTestScript : MonoBehaviour
{
    public DialogMsg msgCaller = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            msgCaller.SetReminder("VINA", "aaafsdfsdfsfsdfsdfs msg", "VINA_happy");
        }
    }
}
