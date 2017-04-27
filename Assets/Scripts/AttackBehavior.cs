using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AttackBehavior : MonoBehaviour
{
    public GameObject swordprefab;
    public Canvas canvas;
    public void Attack()
    {
        GameObject g = GameObject.Instantiate(swordprefab, canvas.transform);
        g.AddComponent<DestroyAfterTime>();
    }
}
