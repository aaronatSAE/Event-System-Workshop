using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Improve this!
                            public class Spotfire : MonoBehaviour
                            {
private void OnDestroy()
{
    BushfireGameManager.firesPutOut++;
}
                            }
