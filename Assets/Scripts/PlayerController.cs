using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game Started");
        //Looks at the GameObject this script is attached to and give it the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Tells me the players horizontal input right now
        float horizontal = Input.GetAxisRaw("Horizontal");
        //Tells me the players vertical input right now
        float vertical = Input.GetAxisRaw("Vertical");
        // Combines horizontal and vertical input into one movement vector giving us the direction and magnitude
        //Vector2 movement = new Vector2(horizontal, vertical).normalized;
        movement = new Vector2(horizontal, vertical).normalized;

        //Handles the movement of the player without RigidBody2D
        //transform.Translate(movement.x * moveSpeed * Time.deltaTime, movement.y * moveSpeed * Time.deltaTime, 0);

        //Handles the movement of the player with RigidBody2D
        //distance = speed * time
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
       
    }

    //Physics system to operate on a fixed time interval
    void FixedUpdate() {
        //Handles player movement with Unity's physic engine
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
