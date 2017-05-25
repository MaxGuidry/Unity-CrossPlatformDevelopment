using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UpdateText : MonoBehaviour
{

    public Text TextToChange;
    public void TextChange(TestPlayerBehavior.PlayerInfo info)
    {
        TextToChange.text = info.health.ToString();
    }
}
