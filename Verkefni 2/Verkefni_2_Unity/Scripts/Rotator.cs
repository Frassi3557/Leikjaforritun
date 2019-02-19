using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    // Eftirfarandi gerist áður en hvert frame er renderað:
    void Update () 
	{
        // Snýr peningunum um Y-ásinn 120° og margfalda það með deltaTime svo að snúningurinn sé á hverri sekúndu frekar en fyrir hvert frame.
		transform.Rotate (new Vector3 (0, 120, 0) * Time.deltaTime);
	}
}	