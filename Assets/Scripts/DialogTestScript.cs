﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (false)
        {
            GameObject.Find("DialogCanvas").GetComponent<DialogMsg>().SetReminder("VINA", "aaafsdfsdfsfsdfsdfs msg", "VINA_happy", "CV_HEY_BIG", 200);
        }
    }
}
