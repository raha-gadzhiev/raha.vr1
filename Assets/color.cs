using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public int a, b, c;
    public GameObject sphere;
    void Start()
    {

    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32 ((byte)a, (byte)b, (byte)c, 1);
        }
    }

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    private void OnMouseEnter()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
    private void OnMouseExit()
    {
        sphere.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}
