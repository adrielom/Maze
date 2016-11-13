using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    //Singleton Method
    public static PlayerManager instance = null;
    float xAxis, zAxis;

	void Awake () {
        if (instance == null) {
            instance = this;
        }

    }

    void Update () {
        Movement ();
    }

    public void RandomicPosition (float a, float b) {
        this.transform.position = new Vector3 (a, 0, b);
    }

    public void Movement () {
        xAxis = Input.GetAxis ("Horizontal");
        zAxis = Input.GetAxis ("Vertical");

        xAxis *= Time.deltaTime;
        zAxis *= Time.deltaTime;

        transform.Translate (xAxis, zAxis, 0);
    }

}
