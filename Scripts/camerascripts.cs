using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascripts : MonoBehaviour
{
public GameObject player;




    void Start()
    {
        
    }

   
    void  Update()
    {
        
    transform.position= player.transform.position + new Vector3 (0, 5, -7);



    }
}
