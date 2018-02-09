using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {

    private GameObject[] arrows;
    private int arrowState;

    private void Awake() {
        arrows = GameObject.FindGameObjectsWithTag("Arrow");
        arrowState = 0;
        InvokeRepeating("ArrowBlink", 0.0f, 0.5f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        //ARROW MANAGEMENT:
        switch (arrowState) {
            case 0: {
                    foreach (GameObject a in arrows) a.SetActive(false);
                    break;
                }
            case 1: {
                    for (int i = 0; i < arrows.Length; i++) {
                        if (i % 2 == 0) arrows[i].SetActive(true);
                        else arrows[i].SetActive(false);
                    }
                    break;
                }
            case 2: {
                    for (int i = 0; i < arrows.Length; i++)
                    {
                        if (i % 2 != 0) arrows[i].SetActive(true);
                        else arrows[i].SetActive(false);
                    }
                    break;
                }
            default:
                break;
        }
	}

    void ArrowBlink() {
        if (arrowState < 3) arrowState++;
        else arrowState = 0;
    }
}
