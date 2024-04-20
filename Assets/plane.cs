using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    private Quaternion defaultRotation;

    private int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)  {
            transform.rotation = defaultRotation;
            transform.Rotate(new Vector3(0, 0, 180));
            direction = 180;
            myRigidbody.velocity = Vector2.down * 5;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
            transform.rotation = defaultRotation;
            transform.Rotate(new Vector3(0, 0, 0));
            direction = 0;
            myRigidbody.velocity = Vector2.up * 5;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
            transform.rotation = defaultRotation;
            transform.Rotate(new Vector3(0, 0, 270));
            direction = 90;
            myRigidbody.velocity = Vector2.right * 5;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
            transform.rotation = defaultRotation;
            transform.Rotate(new Vector3(0, 0, 90));
            direction = 270;
            myRigidbody.velocity = Vector2.left * 5;
        }
        else if (Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = Vector2.zero;
        }
    }
}
