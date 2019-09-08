using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    
    private bool open = false;

    void OnTriggerEnter2D(Collider2D other) {
        if (!open && other.tag == "Shot") {
            open = true;
            GetComponent<Animator>().SetTrigger("Open");
        }
    }

    void DisableCollider() {
        GetComponent<Collider2D>().enabled = false;
    }
}
