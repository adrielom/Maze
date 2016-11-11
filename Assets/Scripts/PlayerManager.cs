using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public int width, height;

    //Singleton Method
    private static PlayerManager instance = null;

	public static PlayerManager GetInstance () {
        if (instance == null) {
            instance = new PlayerManager ();
        }
        return instance;
    }

    void Awake () {
        RandomPosition (width, height);
    }

    public void RandomPosition (int x, int y) {

        transform.position = new Vector3 (Random.Range(0, x-1), transform.position.y, Random.Range (0, y-1));
        
    }

}
