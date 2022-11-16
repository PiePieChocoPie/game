using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 2f;
    Rigidbody2D rb;
    public float jumpForse = 5f;
    SpriteRenderer sr;
    float dash = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movement, 0, 0) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f)
        {
            rb.AddForce(new Vector2(0, jumpForse), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && Mathf.Abs(rb.velocity.x) < 0.05f)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && Mathf.Abs(rb.velocity.x) < 0.05f)
            {
                rb.AddForce(new Vector2(dash, 0) * movement, ForceMode2D.Impulse);
            }
        }
        sr.flipX = movement < 0 ? true : false;

    }
}


