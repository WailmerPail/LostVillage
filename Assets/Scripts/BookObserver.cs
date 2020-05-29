using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookObserver : MonoBehaviour
{
    public GameObject root;
    public string message = "";
    public string avatar = "";
    public string Audio = "";
    public int dialogFrame = 400;
    public static int numberOfBook = 0;
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

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (m_IsPlayerInRange)
            {
                print("I am picked!"); 
                flag_onlytriggerOnce = false;
                BookObserver.numberOfBook++;
                if (BookObserver.numberOfBook == 6) {
                    GameObject.Find("DialogCanvas").GetComponent<DialogMsg>().SetReminder("VINA", "I understand what the energy in these books is.This is my previous energy, or you can call it power. They were Scattered into these books during the previous rampage.That incident sealed myself into the Time.Maybe. . I need your help, can you go North?I now open a portal. Maybe you can enter the void and pull me back.",
                        "VINA_normal", "CV_HEY_DEEP", 1000);
                    root.SetActive(false);
                    return;
                }

                if (message != "")
                    GameObject.Find("DialogCanvas").GetComponent<DialogMsg>().SetReminder("VINA", message, avatar, Audio, dialogFrame);
                root.SetActive(false);
            }
        }
    }




}
