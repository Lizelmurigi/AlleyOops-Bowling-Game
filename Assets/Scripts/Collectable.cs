using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string itemType;

    [SerializeField] ParticleSystem CollectParticle = null;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            collect();
        }

           
    }
    public void collect()


    {
        CollectParticle.Play();
    }





}
