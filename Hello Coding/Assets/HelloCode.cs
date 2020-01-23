using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int exp = 1000;
		if ( exp > 1500 ) {
			Debug.Log("레벨 3이 되었습니다!");
		}
		else if ( exp > 500 ) {
			Debug.Log("레벨 2가 되었습니다!");
		}
		else {
			Debug.Log("레벨업에 실패했습니다!");
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
