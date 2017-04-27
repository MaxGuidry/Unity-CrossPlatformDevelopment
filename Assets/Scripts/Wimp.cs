using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wimp : MonoBehaviour
{

    private float wimpTimer = 2.0f;
    private Quaternion originRotation;
    void Start()
    {
        originRotation = gameObject.transform.rotation;
    } 
    // Update is called once per frame
    void Update()
    {
        if (wimpTimer > 0)
        {
            Quaternion q = new Quaternion(0, 0, Mathf.Sin(Mathf.PI /120), Mathf.Cos(Mathf.PI / 120));
            gameObject.transform.rotation = gameObject.transform.rotation * q;
        }
        else
        {
            Destroy(gameObject.GetComponent<Wimp>());
            gameObject.transform.rotation = originRotation;
        }
        wimpTimer -= Time.deltaTime;
    }
}
