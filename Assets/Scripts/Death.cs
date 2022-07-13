using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private Vector2 initpos;
    private Transform transf;

    // Start is called before the first frame update
    void Start()
    {
        initpos = this.transform.position;
        transf = gameObject.GetComponent<Transform>();
    }

    public void ResetPosicao()
    {
        transf.position = initpos;
        Debug.Log("player reiniciou!");
    }
}
