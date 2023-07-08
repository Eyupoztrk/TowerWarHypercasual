using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private GameObject _spawnPoint;

    [Range(0.1f, 10)]
    public float spawnFrequency;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject(_spawnObject,_spawnPoint.transform);
        }
    }

    public void SpawnObject(GameObject Object,Transform pos)
    {
        GameObject spawnObject = Instantiate(Object, pos.position, Quaternion.identity);
        if (spawnObject.CompareTag("Enemy"))
        {
            spawnObject.transform.localEulerAngles = new Vector3(0,180,0);
        }
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnObject(_spawnObject,_spawnPoint.transform);
            yield return new WaitForSeconds(spawnFrequency);
        }
        
    }

}
