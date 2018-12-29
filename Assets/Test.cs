using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //配列を出力する課題
        int[] array = { 1, 2, 3, 4, 5 };

        //配列内の値を要素順に表示
        for (int i=0;i<array.Length;i++) {
            Debug.Log(array[i]);
        }

        //配列内の値を要素の逆順に表示
        for (int i = array.Length-1; i >=0 ; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
