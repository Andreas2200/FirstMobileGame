using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGen : MonoBehaviour {


    public int Number;
	
	void Start ()
    {

        Number = (int)Random.Range(1, 3);
        Debug.Log(Number);

    }
	
	
	void Update ()
    {
        
	}
}
