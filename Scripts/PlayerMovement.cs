
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float Speed;
    [SerializeField] private bool isPlayer1;
    [SerializeField] private bool isPlayer2;

    private float moveDirection;
   

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (isPlayer1 == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                moveDirection = -1;

            }
            else
            {
                moveDirection = 0;
            }
        }
        if (isPlayer2 == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveDirection = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                moveDirection = -1;
            }
            else
            {
                moveDirection = 0;
            }
        }
       
    }
       
    private void FixedUpdate()
    {
            rb.velocity = new Vector2(0, moveDirection * Speed );

    }
}
