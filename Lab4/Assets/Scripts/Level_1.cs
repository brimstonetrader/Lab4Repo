using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    public GameObject American;


    // Start is called before the first frame update
    void Start()
    {
        American.transform.position = new Vector3(Random.Range(-60f, 45f),Random.Range(-60f, 45f),1);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Collider2D>().gameObject.CompareTag("Player")) {
			GetComponent<AudioSource>().Play();
            Destroy(American);
            print("ff");
		}
    }
}
