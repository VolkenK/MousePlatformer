using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectOnSpawn : MonoBehaviour
{
    void Start()
    {
        //Get the mouse posistion
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        //Make the objects postion = to the mouse position
        transform.position = mousepos;
    }

    void Update()
    {
        //Get the mouse posistion
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        //Make the objects postion = to the mouse position
        transform.position = mousepos;
    }
}
