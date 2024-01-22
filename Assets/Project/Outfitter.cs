using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.U2D.Animation;

public class Outfitter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private SpriteResolver _resolver;

    // Update is called once per frame
    private int _currentHairIndex = 0;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _resolver.SetCategoryAndLabel("Hair", ((HairType)_currentHairIndex).ToString());

            _currentHairIndex++;
            if(_currentHairIndex > 7)
            {
                _currentHairIndex = 0;
            }
        }
    }
}


public enum HairType
{
    Default,
    CrewCut,
    SimpleBlack,
    SimpleBrown,
    SimpleBlonde,
    SimpleGrey,
    SimpleRed,
    ShaggyBlack
}
