using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class FaceController : MonoBehaviour
{

	public SkinnedMeshRenderer mesh;
    public TextMeshProUGUI moo;
	

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		if (mesh.GetBlendShapeWeight(15) > 30)
		{
            moo.gameObject.SetActive(true);
            moo.text = "Mouth open " + (int)mesh.GetBlendShapeWeight(15) + "%";
        } else
        {
            moo.gameObject.SetActive(false);
        }
    }
}
