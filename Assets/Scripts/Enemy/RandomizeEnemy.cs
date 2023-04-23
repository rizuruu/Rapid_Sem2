using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeEnemy : MonoBehaviour
{
    public List<RuntimeAnimatorController> Variations = new List<RuntimeAnimatorController>();

    private int currentVariation = 0;

    // Start is called before the first frame update
    void Awake()
    {
        currentVariation = Random.Range(0, Variations.Count);
        this.GetComponent<Animator>().runtimeAnimatorController = Variations[currentVariation];
    }
}