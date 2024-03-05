using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class kod : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    public GameObject helloText;
    void Start()
    {
        print("hello world");
        helloText.GetComponent<TextMeshPro>().text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        print("hello world !!");
        transform.Translate(new Vector3(0,0,1)* Time.deltaTime * speed);
    }
}
