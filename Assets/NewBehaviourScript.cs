using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NewBehaviourScript
{

    public string myName;

    public void AssingTileMaterial() {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tiles");
        Material material = Resources.Load<Material>("ping");

        foreach(GameObject t in tiles) {
            t.GetComponent<Renderer>().material = material;
        }
    }
}
