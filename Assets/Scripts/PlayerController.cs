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

        //Handles the movement of the player
        transform.Translate(horizontal * moveSpeed * Time.deltaTime, vertical * moveSpeed * Time.deltaTime, 0);

       
    }
}
