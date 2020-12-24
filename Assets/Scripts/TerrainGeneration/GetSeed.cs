using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSeed : MonoBehaviour
{
    public int maxSeedValue = 10000;
    public HeightMapSettings HMS;
    NoiseSettings ns;

    private void Awake()
    {
        ns = HMS.noiseSettings;

        if (DontDestroy.instance.generateRandom)
        {
            ns.seed = Random.Range(0, maxSeedValue);
        }
        else
        {
            ns.seed = DontDestroy.instance.seedInt;
        }
    }
}
