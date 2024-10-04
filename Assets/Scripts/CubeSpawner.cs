using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour{

    public GameObject cube;
    private List<GameObject> spawnedCubes = new List<GameObject>();
    private new Camera camera;
    private Plane[] planes;

    void Start(){
        camera = Camera.main;
        planes = GeometryUtility.CalculateFrustumPlanes(camera);
        Spawn();
    }

    public void Respawn(){
        Despawn();
        Spawn();
    }

    private void Spawn(){
        Vector3 position = new Vector3(Random.Range(-9f, 9f), 0.125f, Random.Range(0f, 7.5f));
        if (IsPointInFrustum(position)){
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0f, 359f), 0);
            GameObject obj = Instantiate(cube, position, rotation);
            spawnedCubes.Add(obj);
        }
        else{
            Spawn();
        }
    }

    bool IsPointInFrustum(Vector3 point){
        foreach (Plane plane in planes){
            if (plane.GetDistanceToPoint(point) < 0){
                return false;
            }
        }
        return true;
    }

    private void Despawn(){
        foreach (GameObject obj in spawnedCubes){
            Destroy(obj);
        }
        spawnedCubes.Clear();
    }

}
