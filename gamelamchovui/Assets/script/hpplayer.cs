using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hpplayer : MonoBehaviour
{
    public Image _hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updatehp(float nowhp,float maxhp)
    {
        _hp.fillAmount = nowhp/maxhp;
    }
}
