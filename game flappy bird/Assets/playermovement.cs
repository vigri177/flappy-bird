using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //neww

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb; //inisialisasi
    public float jumpForce; //Jump loncat
    float score;

    public Text scoreTxt; //neww

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); //perkenalkan inialisasi
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score; //neww

        if (Input.GetMouseButtonDown(0)) //klik mouse kiri for pc / tap untuk hp
        {
            Rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }

        if (collision.gameObject.tag == "pipa")
        {
            Destroy(gameObject);
        }
    }
}
