using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float cameraFromCharacter = -10.0f;
    public float cameraHeight = 4f;
  
    void Update() {
        Vector3 pos = player.transform.position;
        pos.z += cameraFromCharacter;
        pos.y += cameraHeight;
        transform.position = pos;
    }
}
