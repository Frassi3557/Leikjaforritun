using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // Breytur fyrir hraða spilarans og fyrir textann sem heldur utan um stig hans, einnig textann sem kemur er spilarinn vinnur leikinn.
	public float speed;
	public Text countText;
	public Text winText;

    // Private breytur sem kalla á rigidbody og halda utan um hversu marga peninga spilari hefur tekið upp.
	private Rigidbody rb;
	private int count;

	// Eftirfarandi gerist í byrjun leiks:
	void Start ()
	{
        // Breytan rb kallar á rigidbody componentið.
		rb = GetComponent<Rigidbody>();

        // Núllstilli teljarann.
		count = 0;

        // SetCountText uppfærir ui-ið 
		SetCountText ();

        // Tæmi winText svo að það komi ekki "Til Hamingju" í byrjun leiks.
		winText.text = "";
  
	}

    // Allt sem kemur að eðlisfræði er hér fyrir neðan (e. þyngdarafl, massi o.s.frv..)
	void FixedUpdate ()
	{
        // Tekur við input frá notanda.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

        // Tekur input að ofan og setur í nýja breytu.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        // Ýtir boltanum með movement breytunni að ofan og speed, sem hægt er að stilla í Unity.
		rb.AddForce (movement * speed);
	}

    // Þegar objectið rekst á object sem er merkt sem trigger(peningarnir) geymir other breytan trigger objectið.
	void OnTriggerEnter(Collider other) 
	{
        // Ef að trigger objectið er merkt sem Pick Up:
		if (other.gameObject.CompareTag ("Pick Up"))
		{
            // Gerir trigger objectið inactive, sem veldur því að það hverfur.
			other.gameObject.SetActive (false);

            // Bætir 1 við teljara
			count = count + 1;

            // Keyrir SetCountText.
			SetCountText ();
		}
	}

    // Breytan SetCountText sem uppfærir ui og birtir hversu marga peninga spilarinn hefur safnað.
	void SetCountText()
	{
        // Uppfærir textann sem sýnir hversu marga peninga spilarinn hefur safnað.
		countText.text = "Peningar: " + count.ToString ();

        // Ef að spilari hefur náð 10 peningum:
		if (count >= 10) 
		{
            // Birtir winText, sem þýðir að spilari hefur sigrað leikinn.
			winText.text = "Til Hamingju";
		}
	}
}