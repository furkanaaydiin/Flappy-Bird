using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird_Controller : MonoBehaviour
{
    public float JumpForce;
    Rigidbody2D rb;
    private int score;

    public Text TextScore;

    public GameObject GameOverPanel;
    void Start()
    {
        rb= gameObject.GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) )
        {
           rb.velocity = Vector2.up * JumpForce;
        }
    }

    
    private void OnTriggerExit2D(Collider2D col)
    {
     if(col.tag == "Score")
     {
        TextScore.text = score.ToString();
        score++;
     }

    }
     
     private void OnCollisionEnter2D(Collision2D col)
     {
        if(col.gameObject.tag == "Dead")
        {
            Time.timeScale = 0;
            GameOverPanel.SetActive(true);
        }
     }

     public void restart()
     {
        SceneManager.LoadScene(0);
     }
}
