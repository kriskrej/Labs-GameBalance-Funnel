using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentBar : MonoBehaviour {
    [SerializeField] Transform bar;

    public float Percent {
        get { return bar.localScale.x;}
        set { bar.localScale = new Vector3(value,1,1);}

    }
}