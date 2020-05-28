using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObserver : MonoBehaviour
{
    public GameObject root = null;
    public string message = "";
    public string avatar = "";
    public string Audio = "";
    private bool m_IsPlayerInRange;
    private bool flag_onlytriggerOnce = true;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("Model_Professor"))
        {
            m_IsPlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == GameObject.Find("Model_Professor"))
        {
            m_IsPlayerInRange = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (m_IsPlayerInRange && flag_onlytriggerOnce)
        {
            if(message != "")
                GameObject.Find("DialogCanvas").GetComponent<DialogMsg>().SetReminder("VINA", message, avatar, Audio, 200);

            flag_onlytriggerOnce = false;
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            if (m_IsPlayerInRange) {
                if (root != null)
                {
                    OpenDoor.leftKeyNum++;
                    GameObject.Find("ItemCanvas").GetComponent<ItemUIscript>().setNumberofKey(OpenDoor.leftKeyNum);
                    print("you get a key!");
                }
                print("I am picked!");
                root.SetActive(false);
            }
        }
    }




}
