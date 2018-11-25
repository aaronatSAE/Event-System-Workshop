using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotfire : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.firesPutOut++;
    }
}
