using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltHeli : MonoBehaviour {

    private Quaternion up;
	// Use this for initialization
	void Start () {
        GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
        up = g.transform.rotation;
        Destroy(g);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(Mathf.Sin(.01f / 2), 0, 0, Mathf.Cos(.01f / 2));

            //Quaternion q = new Quaternion(0,0,0,1) * new Quaternion(Mathf.Sin(Mathf.PI / 8), 0, 0, Mathf.Cos(Mathf.PI / 8));
            //if (Quaternion.Dot(gameObject.transform.rotation, q) > .9)
            //{
            //}
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(Mathf.Sin(-.01f / 2), 0, 0, Mathf.Cos(-.01f / 2));

            //Quaternion q = new Quaternion(0, 0, 0, 1) * new Quaternion(Mathf.Sin(Mathf.PI / 8), 0, 0, Mathf.Cos(Mathf.PI / 8));
            //if (Quaternion.Dot(gameObject.transform.rotation, q) < .1)
            //{
            //}
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(0,0,Mathf.Sin(.01f / 2), Mathf.Cos(.01f / 2));

        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(0,0,Mathf.Sin(-.01f / 2), Mathf.Cos(-.01f / 2));

        }
        //else
        //{

        //    Quaternion q = gameObject.transform.rotation * new Quaternion(Mathf.Sin(0), 0, 0, Mathf.Cos(0));
        //    float f = Quaternion.Dot(gameObject.transform.rotation, up);
        //    if (Quaternion.Dot(gameObject.transform.rotation, up) < .1)
        //    {
        //        gameObject.transform.rotation = gameObject.transform.rotation * new Quaternion(Mathf.Sin(-.08f / 2), 0, 0, Mathf.Cos(-.08f / 2));
        //        Debug.Log("nig");
        //    }
        // }
    }
}
