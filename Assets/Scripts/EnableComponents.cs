using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private PlayerMovement myPlayermovement;
    // Start is called before the first frame update
    void Start()
    {
        myPlayermovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Disable movement component function
        if (Input.GetKeyUp(KeyCode.P))
        {
            myPlayermovement.enabled = !myPlayermovement.enabled;
        }
    }
}
