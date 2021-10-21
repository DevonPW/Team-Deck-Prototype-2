using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroll : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -19.18) {
            transform.position = new Vector3(0, 0);
        }
    }
}
