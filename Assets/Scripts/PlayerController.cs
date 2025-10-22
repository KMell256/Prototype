using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    public int myNumber = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Debug.Log("My Number Is " + myNumber);
        //Adds 1 every frame to myNumber
        //myNumber = myNumber + 1;
        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn th vehicle
        transform.Rotate(Vector2.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
