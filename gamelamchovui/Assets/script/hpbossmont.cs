using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpboss : MonoBehaviour
{

    public Image _hpboss;
    public void updatehpboss(float nowhpboss, float maxhpboss)
    {
        _hpboss.fillAmount = nowhpboss / maxhpboss;
    }
    
}
