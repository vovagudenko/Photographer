using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    private float horizontal;
    private float vertical;
    // Start is called before the fir
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("horizontal");
        vertical = Input.GetAxis("vertical");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);

    }
}
