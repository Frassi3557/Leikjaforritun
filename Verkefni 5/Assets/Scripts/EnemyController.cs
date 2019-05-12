using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // PlayerDamage gerir ekki neitt, maxSpeed er hámarks hraði sem spilari getur hreyfst á.
    public int PlayerDamage;
    public float maxSpeed = 10f;


    // Eftirfarandi private breytur kalla á Animatorinn, Transform og Rigidbody componentin.
    private Animator anim;
    private Transform target;
    private Rigidbody2D rb;

    // Bool sem er true eða false, eftir því hvort að spilari snýr til hægri eða vinstri.
    bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        // Kallar á rigidbody og animator
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Fær staðsetningu spilarans.
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Hreyfir objectið í áttina að spilaranum þ.e. target.
        transform.position = Vector2.MoveTowards(transform.position, target.position, maxSpeed * Time.deltaTime);
    }

    // Skynjar árekstur milli rigidbody ef að þau eru trigger og tilheyra spilaranum.
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Character")
        {
            Debug.Log("Collision Detected");
            Destroy(col.gameObject);
        }
    }

    // Snýr karakternum um x ásinn svo að það líti út eins og hann hafi snúið sér við.
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
