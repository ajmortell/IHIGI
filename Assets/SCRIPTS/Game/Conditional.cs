using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour {

    bool condition;

    public bool OnCondition(bool value)
    {
        condition = value;

        return condition;
    }
	
}
