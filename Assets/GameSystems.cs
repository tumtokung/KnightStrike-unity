using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystems : MonoBehaviour
{

    public GameObject Botwalk;

    public Vector3 center;
    public Vector3 size;

    
    float timeElapsed = 0;
    float ItemCycle = 2f;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            SpawnBot();
        }
    }
    public void SpawnBot(){
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2,size.x/2),Random.Range(-size.y/2,size.y/2),Random.Range(-size.z/2,size.z/2));

        Instantiate(Botwalk,pos,Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center,size);
    }

}
