using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManaging : MonoBehaviour
{

    //move the ball
    //manage the score
    //manage the turns


    public GameObject ball;
    int score = 0;
    int turnCounter = 0;
    GameObject[] pins;
    public Text scoreUI;
    public int winningScore;

    Vector3[] positions;
    public HighScore highScore;
 

    // Start is called before the first frame update

    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
        positions = new Vector3[pins.Length];
        for (int i = 0; i < pins.Length; i++)
        {
            positions[i] = pins[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();

        if (Input.GetKeyDown(KeyCode.Space) || ball.transform.position.y < -20)
        {
            CountPinsDown();
            turnCounter++;
            ResetPins();


        }

    }

    void MoveBall()
    {
        Vector3 position = ball.transform.position;
        position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -4.78f, 4.78f);
        ball.transform.position = position;
        //ball.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
    void ResetPins()
    {
        {
            for (int i = 0; i < pins.Length; i++)
            {
                pins[i].SetActive(true);
                pins[i].transform.position = positions[i];
                pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                pins[i].transform.rotation = Quaternion.identity;
            }
            ball.transform.position = new Vector3(0.4f, 0.1f, -39.8f);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            ball.transform.rotation = Quaternion.identity;

        }

    }

    void CountPinsDown()
    {
        windisplay();
        for (int i = 0; i < pins.Length; i++)
        {
            if (pins[i].transform.eulerAngles.z > 5 && pins[i].transform.eulerAngles.z < 355 && pins[i].activeSelf)
            {
                score++;
                pins[i].SetActive(false);
                windisplay();
            }
        }
        scoreUI.text = score.ToString();
        if (score > highScore.highScore)
        {
            highScore.highScore = score;
        }
        Debug.Log(highScore.highScore);
    }
    void windisplay()
    {
        if (score >= winningScore)
        {
            SceneManager.LoadScene("LevelDeux");
        }
        



    }

}