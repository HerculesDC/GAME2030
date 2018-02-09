using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour {

    [SerializeField] private int sceneToLoad;
    private Sprite sprite;

    void Awake() {
        sprite = transform.Find("IconSelect").gameObject.GetComponent<Sprite>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoSceneChange() {
        SceneManager.LoadScene(sceneToLoad);
    }
}
