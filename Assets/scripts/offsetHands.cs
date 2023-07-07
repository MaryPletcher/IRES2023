using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetHands : MonoBehaviour
{
    public Transform hand;
    public Vector3 offset = new Vector3(0f, -1.4f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        hand.position = offset;
    }

    // Update is called once per frame
    void Update()
    {
        hand.position = offset;
    }
}
