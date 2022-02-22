using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour{
    public GameObject prefab;

    private void Update(){
        if (Input.GetMouseButtonDown(0))
        {

            GameObject obj = Instantiate(prefab);

            obj.transform.parent = transform;

            obj.transform.localPosition = Vector3.zero;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 dir = ray.direction.normalized;

            obj.GetComponent<Rigidbody>().velocity = (dir * 100.0f);

        }
        
    }


}

