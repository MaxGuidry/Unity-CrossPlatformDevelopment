using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {
    private float timer = 5f;
	// Update is called once per frame
	void Update () {
        if (timer < 0)
            Destroy(gameObject);
        timer -= Time.deltaTime;
	}
}
