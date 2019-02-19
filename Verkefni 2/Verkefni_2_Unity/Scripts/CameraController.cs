using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    // Player heldur utan um player game object, svo að hægt sé að kalla í Transformið.
	public GameObject player;

    // Offset er lengdin sem myndavélin er frá spilara.
	private Vector3 offset;

    // Eftirfarandi gerist í byrjun leiks:
	void Start ()
	{
        // Reiknar lengdina á offset frá spilaranum
		offset = transform.position - player.transform.position;
	}

    // Eftirfarandi gerist áður en hvert frame er renderað:
    void LateUpdate ()
	{
        // Færir myndavélina með spilaranum.
		transform.position = player.transform.position + offset;
	}
}