using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlime : MonoBehaviour
{
    public Vector3 moveChange = new Vector3(0.01f, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10) {
            moveChange.x = -0.01f;
        } else if (transform.position.x < 0) {
            moveChange.x = 0.01f;
        }

        transform.position += moveChange;
    }
}
