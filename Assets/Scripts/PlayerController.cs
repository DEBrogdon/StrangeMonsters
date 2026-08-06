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
        transform.Translate(horizontal * moveSpeed * Time.deltaTime, 0, 0);

       
    }
}
