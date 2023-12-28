using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public Transform camera;
    // Start is called before the first frame update
    
    void LateUpdate()
    {
        transform.LookAt(camera);
    }
}
