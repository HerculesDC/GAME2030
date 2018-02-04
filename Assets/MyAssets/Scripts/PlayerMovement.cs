using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int lives;

    private bool isGrounded;
    [SerializeField] private float downForce;
    [SerializeField] private float sideForce;
    [SerializeField] private float upForce;

    private GameObject curse;
    
    void Awake() {
        curse = transform.Find("Curse").gameObject;
        curse.SetActive(false);
        /*
        downForce = 0.0f;
        upForce = 0.0f;
        sideForce = 0.0f;
        */
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.A)) {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-sideForce, downForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Block")) {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Block")) isGrounded = false;
    }
}
