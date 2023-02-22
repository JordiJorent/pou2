using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SopitasManager : MonoBehaviour
{
    public BoxCollider2D boxSpawn;
    public float maxTime;
    public List<GameObject> sopitaList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maxTime < 0)
        {
            Instantiate(sopitaList[Random.Range(0, sopitaList.Count)], new Vector3(Random.Range(-boxSpawn.bounds.extents.x, boxSpawn.bounds.extents.x), 10.82f, 0f), Quaternion.identity);
            maxTime = 5;
        }
        else
        {
            maxTime -= Time.deltaTime;
        }
    }
}
