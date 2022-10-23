using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 0;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
   



    
    private void Start ()
    {
      rb = GetComponent<Rigidbody2D>();
     

    }

 

   
    
    private void Update()
    {
        Vector3 movement = new Vector3 (Input.GetAxis("Horizontal" ), Input.GetAxis("Vertical"), 0.0f);
        //transform.position = transform.position + movement * Time.deltaTime;
        rb.velocity = new Vector2(movement.x,movement.y);
       
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Magnitude", movement.magnitude);




        /*
         if
        (Input.GetKey(KeyCode.W))
        {
        transform.Translate(0, (_speed * Time.deltaTime) * 1,0);
        //_AnimatorController.Play ("WalkUp");
        }

          if
        (Input.GetKey(KeyCode.A))
        {
        transform.Translate ((_speed* Time.deltaTime)*-1,0,0);
        //_AnimatorController.Play ("WalkLeft");
        }

        if (Input.GetKey(KeyCode.D))
        {
        transform.Translate ((_speed* Time.deltaTime)*1,0,0);
        //_AnimatorController.Play ("WalkRight");
        }
       
        if
        (Input.GetKey(KeyCode.S))
        {
        transform.Translate(0, (_speed * Time.deltaTime) * -1,0); 
        //_AnimatorController.Play ("WalkDown");
        }
        */
        

    
    
}


    





}
