using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.MovePosition(new Vector3 (Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,50)).x, -17));
    }
}
