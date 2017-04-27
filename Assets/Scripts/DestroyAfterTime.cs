using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    float time = 2.0f;

    void Update()
    {
        if (time < 0)
            Destroy(gameObject);
        time -= Time.deltaTime;
        
        Quaternion q = new Quaternion(0, 0, Mathf.Sin(Mathf.PI/120), Mathf.Cos(Mathf.PI/120));
        
        gameObject.transform.rotation = gameObject.transform.rotation * q;
        

    }

}
