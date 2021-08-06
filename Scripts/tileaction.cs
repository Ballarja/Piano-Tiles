using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tileaction : MonoBehaviour
{

    public SpriteRenderer color;
    public bool ishit;
    public int scorevalue = 1;
    public Rigidbody2D rb;
    public int score = 0;
    public float speed = 500f;
    public LayerMask layermask;
    public AudioClip touchsound;
    private int i = 1;
    private bool isclicked;
    // Start is called before the first frame update
    void Start()
    {
        ishit = false;
        isclicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, - speed * Time.deltaTime, 0);
        if(FindObjectOfType<score>().scoree > i * 10)
        {
            speed += 100f;
            i++;
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isclicked == false)
            {
                // Debug.Log(speed);
                AudioSource.PlayClipAtPoint(touchsound, transform.position);
                color.color = Color.cyan;
                FindObjectOfType<score>().Scoreupdate(scorevalue);
                isclicked = true;

            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
       if (color.color == Color.cyan)
       {
           //Debug.Log("you are fine");
       }
       else if (col.collider.tag == "border")
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           UnityAdManager.instance.ShowAd();
       }

    }
}
