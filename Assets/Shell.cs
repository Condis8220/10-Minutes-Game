using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shell : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = Vector2.right * speed;

        if (transform.position.x > 0)
        {
            Counter.Add();
            Destroy(gameObject, 3);
            Destroy(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Counter.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
