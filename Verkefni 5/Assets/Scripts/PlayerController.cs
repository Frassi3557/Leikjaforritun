using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 10f;

    bool facingRight = true;
    bool armed;

    public Collider2D attackTrigger;

    Animator anim;

    private Rigidbody2D rb;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        armed = false;
        attackTrigger.enabled = false;
    }

    private void Update()
    {
        // Ef að ýtt er á SPACE er armed boolið true og það kveikir á trigger í animator sem spilar svo attack animationið.
        if (Input.GetButtonDown("Jump"))
        {
            armed = true;
        }
        else
        {
            armed = false;
        }
        if (armed == true)
        {
            anim.SetTrigger("Attack");
            attackTrigger.enabled = true;
        }
        else
        {
            attackTrigger.enabled = false;
        }
    }

    // Update is called once per frame
    // Sér um að snúa karakter og hreyfa hann miðað við input frá notanda.
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    // Ef að það er árekstur milli rigidbody þá eyðir leikurinn óvininum.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision Detected");
            other.gameObject.SetActive(false);

            count += count + 1;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
