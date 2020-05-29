using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform tf; //variable for transform component
    public float speed = .01f; // variable for designersto adjust speed within unit editor
    private Vector3 startPosition; //variable to reset player position

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the player holds the shift modifier the sprite only moves one unit at a time
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                tf.position = tf.position + Vector3.left * 1f;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                tf.position = tf.position + Vector3.right * 1f;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * 1f;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tf.position = tf.position + Vector3.down * 1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                tf.position = tf.position + Vector3.left * speed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                tf.position = tf.position + Vector3.right * speed;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                tf.position = tf.position + Vector3.up * speed;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                tf.position = tf.position + Vector3.down * speed;
            }
        }
        //Player position reset function
        if (Input.GetKey(KeyCode.Space))
        {
            tf.position = startPosition;
        }
    }
}
