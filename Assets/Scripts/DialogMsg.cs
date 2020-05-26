using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogMsg : MonoBehaviour
{
    public Image headImage;
    public GameObject nameText;
    public GameObject messageText;
    // Start is called before the first frame update
    public static int maxshowFrame = 1000;
    public int leftshowFrame = 1000;
    private bool visible = false;

    void Start()
    {
        gameObject.SetActive(false);
        visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!visible)
        {
            return;
        }
        leftshowFrame--;
        if (leftshowFrame == 0)
        {
            leftshowFrame = maxshowFrame;
            gameObject.SetActive(false);
            visible = false;
        }
    }

    public void SetReminder(string name, string message, string image)
    {
        gameObject.SetActive(true);
        visible = true;
        nameText.GetComponentInChildren<Text>().text = name;
        messageText.GetComponentInChildren<Text>().text = message;
        headImage.sprite = Resources.Load<Sprite>(image);
    }

}
