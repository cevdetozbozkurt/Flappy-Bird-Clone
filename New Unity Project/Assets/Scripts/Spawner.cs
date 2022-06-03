using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float time;
    public Bird bird;
    public GameObject Pipes;
    public float height;

    private void Start()
    {
        StartCoroutine(SpawnerObject(time));
    }

    public IEnumerator SpawnerObject(float time)
    {
        while (!bird.isDead)
        {
            Instantiate(Pipes, new Vector3(1.76f, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
