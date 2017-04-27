﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellicopterBlade : MonoBehaviour
{

    private float timer;
    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 5)
        {
            timer += Time.deltaTime / 3;
        }
        SpinDatHoe();
        

    }

    void SpinDatHoe()
    {
        Quaternion q1 = gameObject.transform.rotation;
        gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(0, Mathf.Sin(timer / 20), 0, Mathf.Cos(timer / 20));
        Quaternion q2 = gameObject.transform.rotation;
        float dot = Quaternion.Dot(q1, q2);
        Rigidbody rigidbody = gameObject.GetComponentInParent<Rigidbody>();
        Vector3 Force = gameObject.transform.up * timer;//new Vector3(gameObject.transform.localEulerAngles.x, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z) * timer;
        rigidbody.AddForce(Force);
    }
}