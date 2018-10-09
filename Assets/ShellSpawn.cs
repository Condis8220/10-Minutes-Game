using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSpawn : MonoBehaviour
{
    public GameObject shell;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2);

        while (true)
        {
            GameObject temp = Instantiate(shell, transform.position, Quaternion.identity);
            temp.GetComponent<Shell>().speed = Random.Range(8, 13);

            yield return new WaitForSeconds(Random.Range(2, 4));
        }
    }
}
