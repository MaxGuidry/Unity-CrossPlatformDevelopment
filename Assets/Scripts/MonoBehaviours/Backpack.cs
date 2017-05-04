using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Backpack : MonoBehaviour
{

    public List<ScriptableObjects.Item> inventory;
    private List<GameObject> inventorySlots = new List<GameObject>();
    private int index = 0;
    // Use this for initialization
    void Start()
    {
       

        var gs = GameObject.FindGameObjectsWithTag("Inventory slot");
        //List<GameObject> olist = new List<GameObject>(gs);
        //var v = olist[0];

        //olist.Sort((x, y) => x.GetComponent<RectTransform>().position.y.CompareTo(y.GetComponent<RectTransform>().position.y));
        //List<GameObject> top = olist.GetRange(0, olist.Count / 2);
        //top.Sort((x, y) => x.transform.localPosition.x.CompareTo(y.transform.localPosition.x));
        //List<GameObject> bottom = olist.GetRange(olist.Count / 2, olist.Count / 2);
        //bottom.Sort((x, y) => x.transform.localPosition.x.CompareTo(y.transform.localPosition.x));
        //inventorySlots.AddRange(top);
        //inventorySlots.AddRange(bottom);
        inventorySlots.AddRange(gs);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rn = Random.Range(0, 4);
            switch (rn)
            {
                case 0:
                    inventory.Add(new ScriptableObjects.BarettaM92());
                    break;
                case 1:
                    inventory.Add(new ScriptableObjects.CombatKnife());
                    break;
                case 2:
                    inventory.Add(new ScriptableObjects.KevlarVest());
                    break;
                case 3:
                    inventory.Add(new ScriptableObjects.Sheild());
                    break;
            }
            UnityEngine.UI.Image i = inventorySlots[index].GetComponent<UnityEngine.UI.Image>();
            var mat = Resources.LoadAll<Sprite>("sword_sprites");
            i.sprite = mat[index];
            index++;
        }
    }
}
