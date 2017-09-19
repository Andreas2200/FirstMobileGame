using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {


    NumberGen NG;
    UIManager UM;
	
	void Start ()
    {
        NG = FindObjectOfType<NumberGen>();
        UM = FindObjectOfType<UIManager>();
    }
	
	
	void Update ()
    {
		
	}

    public void Button1Press()
    {
        if (NG.Number == 1)
        {
            UM.Number.text = ("The Number is: " + NG.Number);
            UM.NumberManager.SetActive(true);
        }
        else
        {
            UM.Number.text = ("You were wrong, the number was " + NG.Number);
            UM.NumberManager.SetActive(true);
        }
    }

    public void Button2Press()
    {
        if (NG.Number == 2)
        {
            UM.Number.text = ("The Number is: " + NG.Number);
            UM.NumberManager.SetActive(true);
        }
        else
        {
            UM.Number.text = ("You were wrong, the number was " + NG.Number);
            UM.NumberManager.SetActive(true);
        }
    }
}
