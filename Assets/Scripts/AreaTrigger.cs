using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;


public class AreaTrigger : MonoBehaviour
{

    private bool _playerInRange;
   [SerializeField] private GameObject _sprite;

    // Start is called before the first frame update

    void Start()
    {
        _playerInRange = false;
        _sprite.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        //PickUp();
    }
    
       

    

    private void OnTriggerEnter2D(Collider2D collider)
        {
             if (collider.tag == "Player")
            _playerInRange = true;
            Debug.Log("Игрок зашёл");
            _sprite.SetActive(true);

        }
    private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.tag != "Player")
            _playerInRange = false;
            Debug.Log("Игрок вышел");
            _sprite.SetActive(false);


        }
        /*public void PickUp()
      { 
          if 
           (Input.GetKey(KeyCode.R) & _playerInRange )
        { 
            //QuestLog.SetQuestState ("HelpMila", "active");
            DialogueLua.SetVariable("RequestMila.FIndBook", true);
            Debug.Log("Книжка подобрана");
        }
      }
      */
    

}



