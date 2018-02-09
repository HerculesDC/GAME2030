using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehavior : MonoBehaviour {

    [SerializeField] private float delay;
    [SerializeField] private float repeatRate;

    private Sprite sprite;

    void Awake() { sprite = GetComponent<Sprite>(); }
	// Use this for initialization
	void Start () { InvokeRepeating("Flashing", delay, repeatRate); }

    void Flashing() {
    }
}
