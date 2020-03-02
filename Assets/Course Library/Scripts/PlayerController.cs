using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    const float hozBoudary = 10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 3;
        float result = 1.0f / num1;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        //Don't let player move of the grass to the right
        if(transform.position.x > hozBoudary)
        {
            transform.position = new Vector3(hozBoudary, transform.position.y, transform.position.z);
        }
        //Don't let player move of the grass to the left
        /*if (transform.position.x < -hozBoudary)
        {
            transform.position = new Vector3(-hozBoudary, transform.position.y, transform.position.z);
        }*/

        float hozInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * hozInput * Time.deltaTime * speed); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
