using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public bool isPlay;
    public bool isHelp;
    public bool isOptions;
    public bool isExit;
    
	void OnMouseUP()
    {
        if(isPlay)
        {

            Application.LoadLevel(1);

            Application.LoadLevel(3);

        }

        if (isHelp)
        {

            Application.LoadLevel(3);

            Application.LoadLevel(2);

        }

        if (isOptions)
        {

            Application.LoadLevel(0);

            Application.LoadLevel(1);

        }

        if (isExit)
        {
            Application.Quit();
        }
    }
}
