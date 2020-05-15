using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{

    public float stone;
    public float maxStone;

    public float wood;
    public float maxWood;
    
    public float population;
    public float maxPopulation;

    public Text stoneDisp;
    public Text woodDisp;
    public Text populationDisp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stoneDisp.text = "" + stone + "/" + maxStone;
        woodDisp.text = "" + wood + "/" + maxWood;
        populationDisp.text = "" + population + "/" + maxPopulation;

    }
}
