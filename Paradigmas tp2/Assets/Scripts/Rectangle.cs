using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    public CanvasManager canvasManager;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cube>() != null)
        {
            string playerName = collision.gameObject.GetComponent<Cube>().Name;
            canvasManager.ChangeMessage("Hello, " + playerName + "!");
            anim.Play("Rectangle Animation");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        anim.Play("Static");
        canvasManager.HideMessage();
    }
}
