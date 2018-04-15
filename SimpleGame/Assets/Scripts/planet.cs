using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour {


    public GameObject objectToDestroy;

    void OnMouseDown()
    {
        Destroy(objectToDestroy);
    }
    void End()
    {
        Destroy(this.objectToDestroy);
    }

}
