using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPins : MonoBehaviour
{
    public Transform kegel;
    public float threshold = .6f;
    public int point = 1;
    public Score score;

    void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();

    }
    void checkItFell()
    {
        try
        {
            if (kegel.up.y < threshold)
            {
                score.Add(point);
                gameObject.GetComponent<Collider>().enabled = false;
            }
        }
        catch
        {
            Debug.Log("Looks like the kegel went into the Dead Zone!!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        checkItFell();
    }
}
