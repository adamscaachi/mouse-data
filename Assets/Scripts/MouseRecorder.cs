using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRecorder : MonoBehaviour{

    private int width;
    private int height;
    private string filePath;
    private Vector2 position;
    private float time;
    private List<Vector3> data = new List<Vector3>();
    private int eventID = 0;
    private string dir;
    private float startTime = 0;

    void Start(){
        width = Screen.width;
        height = Screen.height;
        string timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        dir = Path.Combine("Data", timestamp);
        Directory.CreateDirectory(dir);
    }

    public void RecordEvent(){
        if (eventID > 0){
            filePath = Path.Combine(dir, $"{eventID.ToString("D4")}.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true)) {
                foreach (Vector3 point in data) {
                    writer.WriteLine($"{point.x},{point.y},{point.z}");
                }
            }
        }
        data.Clear();
        eventID++;
        Debug.Log(eventID);
        startTime = Time.time;
    }

    void Update(){
        position = Input.mousePosition;
        time = Time.time - startTime;
        data.Add(new Vector3(position.x/width, position.y/height, time));
    }

}