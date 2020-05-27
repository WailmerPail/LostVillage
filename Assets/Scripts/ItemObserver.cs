using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObserver : MonoBehaviour
{
    public GameObject root;
    public Transform player;
    public string message;
    public string avatar;
    public string Audio;
    private bool m_IsPlayerInRange;
    private bool flag_onlytriggerOnce = true;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
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
            GameObject.Find("DialogCanvas").GetComponent<DialogMsg>().SetReminder("VINA", message, avatar, Audio);
            flag_onlytriggerOnce = false;
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            if (m_IsPlayerInRange) {
                print("I am picked!");
                root.SetActive(false);
            }
        }
    }




}
