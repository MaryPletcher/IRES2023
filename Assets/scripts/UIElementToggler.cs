using UnityEngine;

public class UIElementToggler : MonoBehaviour
{
    public GameObject CHAT1; // Reference to the UI element you want to toggle
    public GameObject CHAT2; // Reference to the UI element you want to toggle
    public GameObject CHAT3;
    public GameObject CHAT4; // Reference to the UI element you want to toggle
    public GameObject CHAT5; // Reference to the UI element you want to toggle
    public GameObject CHAT6;
    public GameObject CHAT7;

    public float time1 = 5f; // The time interval in seconds for toggling the UI element
    public float time2 = 10f;
    public float time3 = 15f;
    public float time4 = 20f; // The time interval in seconds for toggling the UI element
    public float time5 = 25f;
    public float time6 = 30f;

    public float time7 = 35f;

    private float timer;

    private void Start()
    {
        CHAT1.SetActive(true);
        CHAT2.SetActive(false);
        CHAT3.SetActive(false);
        CHAT4.SetActive(false);
        CHAT5.SetActive(false);
        CHAT6.SetActive(false);
        timer = 0f;
    }

    private void Update()
    {
        Debug.Log("time: " + timer.ToString());
        timer += Time.deltaTime;
        
        if (timer > 0f && timer <= time1)
        {
            CHAT1.SetActive(true);
            //Debug.Log("chat1: " + CHAT1.activeSelf);
        }
        
        else if (timer > time1 && timer <= time2)
        {
            CHAT1.SetActive(false);
            CHAT2.SetActive(true);
            //Debug.Log("chat1: " +CHAT1.activeSelf);
            //Debug.Log("chat2: " +CHAT2.activeSelf);
        }


        else if (timer > time2 && timer <= time3)
        {
            CHAT2.SetActive(false);
            CHAT3.SetActive(true);
            
        }

        else if (timer > time3 && timer <= time4)
        {
            CHAT3.SetActive(false);
            CHAT4.SetActive(true);
            
        }

        else if (timer > time4 && timer <= time5)
        {
            CHAT4.SetActive(false);
            CHAT5.SetActive(true);
            
        }

        else if (timer > time5 && timer <= time6)
        {
            CHAT5.SetActive(false);
            CHAT6.SetActive(true);
            
        }

         else if (timer > time6 && timer <= time7)
        {
            CHAT6.SetActive(false);
            CHAT7.SetActive(true);
            
        }
        
       /*  Debug.Log("chat1: " +CHAT1.activeSelf);
        Debug.Log("chat2: " +CHAT2.activeSelf);
        Debug.Log("chat3: " +CHAT3.activeSelf);
        Debug.Log("chat4: " +CHAT4.activeSelf);
        Debug.Log("chat5: " +CHAT5.activeSelf);
        Debug.Log("chat6: " +CHAT6.activeSelf);
        Debug.Log("chat3: " +CHAT3.activeSelf); */


    }
}
