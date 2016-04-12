using UnityEngine;
using System.Collections;

public class CoreBehaviour : MonoBehaviour {
    static int towerhealth;
    static bool gameOn;
	// Use this for initialization
	void Start () {
        towerhealth = 100;
        gameOn = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(towerhealth);
        if (towerhealth <= 0)
        {
            Debug.Log("Error Health");
            //GAMEOVER
            Application.LoadLevel(2);

        }//end if
	}

    public static void addHealth(int x)
    {
        towerhealth += x;

    }//end addHealth

    public static void takeHealth(int x)
    {
        towerhealth -= x;

    }//end takeHealth

    public static int getHealth()
    {
        return towerhealth;
    }
}
