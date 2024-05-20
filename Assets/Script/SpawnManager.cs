using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameObject2;

    private float time;

    private bool spawn = true;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 2 && spawn)
        {
            Instantiate(gameObject2, new Vector3(GetRandomRange(-10, 10), transform.position.y, 0), Quaternion.identity);
            time = 0;
        }
        time += Time.deltaTime;
    }


    private int GetRandomRange(int min, int max)
    {
        return Random.Range(min, max);
    }
}
