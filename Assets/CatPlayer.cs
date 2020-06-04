using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        Cat kitty = new cat("kitty");
        kitty.playSound();
        kitty.Go();

        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.upArrow))
        {
            Debug.Log("앞으로~");
            transform.position = new Vector3(
                fransform.position.x
                , fransform.position.y
                , fransform.position.z + 3f * Time.deltaTime
                );
        }
        if (Input.GetKey(KeyCode.upArrow))
        {
            Debug.Log("뒤로~");
            transform.position = new Vector3(
                fransform.position.x
                , fransform.position.y
                , fransform.position.z - 3f * Time.deltaTime);
        }
    }

}
