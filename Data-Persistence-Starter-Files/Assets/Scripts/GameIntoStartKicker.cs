using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIntoStartKicker : MonoBehaviour
{
    [SerializeField] BetweenScenesPersistanceSO betweenScenesPersistance;
    [SerializeField] GameObject mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        betweenScenesPersistance.Initialize(mainCanvas);
    }

}
