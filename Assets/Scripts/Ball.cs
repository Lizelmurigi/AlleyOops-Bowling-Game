using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public List<string> inventory;
    [SerializeField] float power;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inventory = new List<string>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            rb.AddForce(Vector3.forward * power);
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }

    }





    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Collectable"))
        {




            string itemType = collision.gameObject.GetComponent<Collectable>().itemType;
            print("we have collected a:" + itemType);
            inventory.Add(itemType);
            print("Inventory length:" + inventory.Count);

            Destroy(collision.gameObject);
            



        }
    }
}
