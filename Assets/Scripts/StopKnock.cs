using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopKnock : MonoBehaviour

{
    public AudioSource knock;
    
    // Start is called before the first frame update
    void Start()
    {
        knock = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
        {
             if (collider.tag == "Player")
            knock.Stop();
            Debug.Log("Игрок зашёл");
            

        }
}
