using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _objectsPrefabs;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-1.9f, 1.9f), transform.position.y, -1f);
            Instantiate(_objectsPrefabs[Random.Range(0, _objectsPrefabs.Length)], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1.2f, 1.6f));
        }
    }
}
