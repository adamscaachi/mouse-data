using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour{

    private MouseRecorder mouseRecorder;
    private CubeSpawner cubeSpawner;

    void Start(){
        mouseRecorder = FindObjectOfType<MouseRecorder>();
        cubeSpawner = FindObjectOfType<CubeSpawner>();
    }

    void OnMouseDown(){
        mouseRecorder.RecordEvent();
        cubeSpawner.Respawn();
    }


}
