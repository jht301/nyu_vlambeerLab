using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class managerScript : MonoBehaviour {
    public static managerScript me;
    public int globalTileCount;
    public int maxTiles;

    public bool die;
    // Use this for initialization
    void Awake () {
		if(managerScript.me == null) {
            me = this;
        }
        else {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R)) {
            globalTileCount = 0;
            SceneManager.LoadScene(0);
        }
	}
}
