using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    private GameObject _Player;
    void Start()
    {
        //Find active player
        _Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Check if mouse button is down
        if(Input.GetMouseButtonDown(0))
        {
            //Get the playerpos
            Vector3 playerpos = _Player.transform.position;
            //Destroy player
            Destroy(_Player);
            //Make this objects position = to the active player
            this.transform.position = playerpos;
            //Destroy the GameObjectOnSpawn component
            Destroy(this.GetComponent<GameObjectOnSpawn>());
            //Make this objects tag Player
            this.tag = "Player";
            //Destroy this script on the gameobject
            Destroy(this.GetComponent<PlayerSwitch>());
        }
    }
}
