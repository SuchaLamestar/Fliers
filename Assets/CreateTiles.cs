using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTiles : MonoBehaviour
{

    public GameObject tiler;
    GameObject tilerClone;

    void Start() {

        for (int i = 0; i < 10; i++)
        {
            for (int ii = 0; ii < 10; ii++)
            {
                tilerClone = Instantiate(tiler, new Vector3(transform.position.x + i, transform.position.y, transform.position.z + ii), Quaternion.identity) as GameObject;
                tilerClone.name = "Tile" + i + "." + ii;
            }
        }
    }
}
