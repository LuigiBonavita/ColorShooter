using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Nemico"))
        {
            Destroy(gameObject);
            Debug.Log("Hai perso");

        }
    }
}
