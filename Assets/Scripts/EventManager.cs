using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


    public delegate void Killable();
    public static event Killable Killed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TurnColor()
    {
        /*if (scrivere la condizione)
        {
            if (Killed != null)
                Killed();
        }*/
    }
}
