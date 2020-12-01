using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private PlacmentIndicator placmentIndicator;

    private void Start()
    {
        placmentIndicator = FindObjectOfType<PlacmentIndicator>();
    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, placmentIndicator.transform.position, placmentIndicator.transform.rotation);
        }
    }

}
