using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TShooter : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject obj = Instantiate(prefab);
            //obj.transform.parent = transform;
            //obj.transform.localPosition = Vector3.zero;
            obj.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, -180);
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 dir = ray.direction.normalized;
            obj.GetComponent<Rigidbody>().velocity = obj.transform.position * 10.0f;
        }
    }
}
