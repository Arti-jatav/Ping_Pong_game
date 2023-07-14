
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D ball;
    [SerializeField] private float Speed;
    [SerializeField] private Text P1ScoreTxt;
    [SerializeField] private Text P2ScoreTxt;
    private static int count1 = 0;
    private static int count2 = 0;
    public int scoreToReach;
    public GameObject gameOver;
    public GameObject p1;
    public GameObject p2;
    public GameObject hitSfx;

    void Start()
    {
        ball.AddForce(new Vector2(-2 * Speed, -2 * Speed));
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Left")
        {
            count1++;
            CheckScore();
            P1ScoreTxt.text = count1.ToString();
            Restart(collision);
        }
        else if (collision.tag == "Right")
        {
            count2++;
            CheckScore();
            P2ScoreTxt.text = " " + count2.ToString();
            Restart(collision);
        }
    }
   public void BallSound(Collider2D collision)
    {
        if (collision.gameObject)
        {
            Instantiate(hitSfx, transform.position, transform.rotation);
            Debug.Log("sound");
        }
    }

    public void Restart(Collider2D collision)
    {
        transform.position = Vector2.zero;
        ball.velocity = Vector2.zero;
        if(collision.gameObject.tag == "Left")
        {
            ball.AddForce(new Vector2(-2 * Speed, -2 * Speed));
        }
        else
        {
            ball.AddForce(new Vector2(2 * Speed, 2 * Speed));
        }
       
    }
    public void CheckScore()
    {
        if (count1 == scoreToReach || count2 == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
    
   

    void Update()
    {

    }
}

