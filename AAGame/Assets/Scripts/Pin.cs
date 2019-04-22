using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float force = 25f;
    public Rigidbody2D pinRB;

    private bool hasClicked = false;
    [HideInInspector]
    public bool isPinned = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasClicked = true;
        }

        if (hasClicked)
        {
            if (!isPinned)
            {
                pinRB.MovePosition(pinRB.position + Vector2.up * force * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);

            ++Score.PinCount;
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            GameManager.instance.EndGame();
            transform.SetParent(collision.transform);     
            
            isPinned = true;
        }
    }
}
