using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject NumberManager;
    public Text Number;
    public Button Button1;
    public Button Button2;
    NumberGen NG;


	void Start ()
    {
        NG = FindObjectOfType<NumberGen>();
        NumberManager.SetActive(false);
        
	}
	
	
	void Update ()
    {
        
    }

}
