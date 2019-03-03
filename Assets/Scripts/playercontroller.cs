using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {

    public float speed;
    public Text CountText;
    public Text winText;
    private Rigidbody rb;
    private int Count;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Count = 0;
        SetCountText();
        winText.text = "";

    }

    private void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movehorizontal, 0, movevertical);


        rb.AddForce(movement*speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Count = Count + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        CountText.text = "Count:  " + Count.ToString();
        if (Count>= 8)
        {
            winText.text = "YOU WIN";

        }
    }
}
