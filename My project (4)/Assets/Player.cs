using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 move;
    public int HP;
    int result;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + move * speed);
        if(HP < 1)
        {
            SceneManager.LoadScene("SampleScene"); 
        }
    }

    public void Damage(int dmg)
    {
        HP -= dmg;
    }
}
