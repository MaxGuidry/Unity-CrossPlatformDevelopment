using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RunChoiceBehaviour : MonoBehaviour
{
    public Text info;
	public void Run()
    {
        info.text = "You are running..." + Environment.NewLine;
    }
	
}
