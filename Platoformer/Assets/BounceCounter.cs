using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int counter = 0;
    private void OnCollision2D(Collision2D collision)
    {
        counter += 1;
        Debug.Log(counter);
    }
}
