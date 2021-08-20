using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDown : MonoBehaviour
{
    [SerializeField] private float speedPrefab = 1f;
    [SerializeField] private float sacleTime;
   
    // Update is called once per frame
    
    void Update()
    {
        while (true)
        {
            sacleTime += 0.25f;
        }
        transform.Translate(Vector3.down * Time.deltaTime * sacleTime);
    }
}
