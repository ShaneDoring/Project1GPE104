using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerShip; //variable for controlling the PlayerShip Game object witht he GameManager*must attach the GameObject in Unity Editor
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //function for disabling/enabling the PlayerShip Game Object
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerShip.SetActive(!playerShip.activeInHierarchy);
        }
        //Function for exiting the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}
