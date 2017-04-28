using System;
using UnityEngine;
using UnityEngine.UI;

public class RunChoiceBehaviour : MonoBehaviour
{
    public Camera mainCamera;
    public Text InformationText;
    private float wimpTimer = 2.0f;
    public void Run()
    {
        const string info = "Run Choice Selected I am running....";
        InformationText.text += info + Environment.NewLine;
// mainCamera.gameObject.AddComponent<Wimp>();
    }
  
}
