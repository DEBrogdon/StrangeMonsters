using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        //Tells me the players horizontal input right now
        float horizontal = Input.GetAxisRaw("Horizontal");
        //Tells me the players vertical input right now
        float vertical = Input.GetAxisRaw("Vertical");
        // Combines horizontal and vertical input into one movement vector
        Vector2 movement = new Vector2(horizontal, vertical);
        //Property of normalize the movement
        movement = movement.normalized;

        //Handles the movement of the player
        transform.Translate(movement.x * moveSpeed * Time.deltaTime, movement.y * moveSpeed * Time.deltaTime, 0);

       
    }
}
