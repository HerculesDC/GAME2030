using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour {

    public bool activated = false;

    private GameObject blueBlock;
    private GameObject yellowBlock;

    void Awake() {
        blueBlock = this.gameObject.transform.Find("Inactive").gameObject;
        yellowBlock = this.gameObject.transform.Find("Active").gameObject;
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
