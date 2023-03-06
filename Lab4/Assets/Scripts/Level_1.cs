using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    public GameObject American;
    public AudioSource audio; 

    public int c = 100;
    public string text;


    public void OnTriggerEnter2D(Collider2D collider2D) {
        StartCoroutine("Beep");
        print("Entered..");
        StopCoroutine("Beep");
    }
    public void OnTriggerExit2D(Collider2D collider2D) {
        StopCoroutine("Beep");
    }
    IEnumerator Beep()
    {
        if (GetComponent<Collider2D>().gameObject.CompareTag("Player")) {
			audio.Play();
            American.GetComponent<Renderer>().material.color = Color.red;
            c--;
            yield return new WaitForSeconds(0.1f);
            audio.Pause();
            print("ff");
		}
    }

    // Start is called before the first frame update
    void Start()
    {
        American.transform.position = new Vector3(Random.Range(-60f, 45f),Random.Range(-60f, 45f),1);
    }




        

    // Update is called once per frame
    void Update()
    {

    }
}
