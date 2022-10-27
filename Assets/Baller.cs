using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baller : MonoBehaviour
{
   
    public List<string> inventory;
    private Rigidbody rb;
    public float Speed = 30f;
    private bool thrown = false;
    public float horizontalSpeed = 0.1f;
    


    // Start is called before the first frame update
    void Awake()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    void start()
    {
        inventory = new List<string>();
        
    }

    // Update is called once per frame
    void Update()
    {
        BallMovement();

    }

     void BallMovement()
    {
        //Movement
        if(!thrown)
        {
            float xAxis = Input.GetAxis("Horizontal");
            Vector3 position = transform.position;
            position.x += xAxis * horizontalSpeed;
            transform.position = position;
        }
        if(!thrown && Input.GetKeyDown(KeyCode.Space))
        {

            thrown = true;
            rb.isKinematic = false;
            rb.velocity = new Vector3(0, 0, Speed);
        }



    }
   
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Collectable"))
        {

          
         

            string itemType = collision.gameObject.GetComponent<Collectable>().itemType;
            print("we have collected a:" + itemType);
            inventory.Add(itemType);
            print("Inventory length:" + inventory.Count);

            Destroy(collision.gameObject);

        }
    }

            
}
