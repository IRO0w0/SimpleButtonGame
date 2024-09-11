using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarEF : MonoBehaviour
{
    public GameObject star;
    private float spawnTime;
    private float defaultTime = 0.1f;
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && spawnTime >= defaultTime)
        {
            MakeStar();
            spawnTime = 0;
        }
        spawnTime += Time.deltaTime;

    }
    void MakeStar()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Instantiate(star, mouse, Quaternion.identity);
    }
}
