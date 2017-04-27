using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class DefendBehavior : MonoBehaviour {

    public Text t;
    public GameObject sheildprefab;
    public GameObject contentWindow;

    public void defend()
    {
        GameObject g = GameObject.Instantiate(sheildprefab, contentWindow.transform) as GameObject;
        var v = Resources.LoadAll<Sprite>("");

        t.text = "You are defending.";
        g.AddComponent<DestroyAfterTime>();
        var randomSprite = Random.Range(0, v.Length);
        var sp = Resources.LoadAll<Sprite>("sword_sprites");
        while(sp.ToList<Sprite>().Contains(v[randomSprite]))
        {
            randomSprite = Random.Range(0, v.Length);
        }
        g.GetComponent<Image>().sprite = v[randomSprite];
    }
}
