using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour {

    public bool activated = false;

    private GameObject blueBlock;
    private GameObject yellowBlock;

    void Awake() {
        blueBlock = GameObject.Find("Inactive");
        yellowBlock = GameObject.Find("Active");
        blueBlock.SetActive(true);
        yellowBlock.SetActive(false);
    }
    
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player") && !activated) {
            activated = true;
            blueBlock.SetActive(false);
            yellowBlock.SetActive(true);
        }
    }
}
