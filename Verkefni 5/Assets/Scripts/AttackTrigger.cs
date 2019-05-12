using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    // Þetta script virkaði ekki
    
    public int dmg = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger != true && collision.CompareTag("Enemy")) 
        {
            Debug.Log("Collision Detected");
            Destroy(collision.gameObject);
        }
    }
}
