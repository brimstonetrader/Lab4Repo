using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    public GameObject American;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++) {
            var position = new Vector3(Random.Range(-70f, 35f), Random.Range(-70f, 40f), 1);
            Instantiate(American, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
