using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timerCar : MonoBehaviour
{
    public Text text;

    public Text gameover;


   public float timeLeft;

    void Start()
    {
       
    }

    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {

            gameover.text = "gameover boii";
            

            //Application.LoadLevel("gameOver");
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        timeLeft += 10f;

        // Revert the cube color to white.
       // MeshRenderer meshRend = GetComponent<MeshRenderer>();
      //  meshRend.material.color = Color.white;
    }



}
