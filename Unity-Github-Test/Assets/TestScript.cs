using UnityEngine;
using System.Collections;

namespace Softdrink{

	public class TestScript : MonoBehaviour {

		// Woooooo testing github stuff~

		private Transform self;

		// Use this for initialization
		void Start () {
			self = gameObject.GetComponent(typeof(Transform)) as Transform;
		}
		
		// Update is called once per frame
		void Update () {
			self.position = new Vector3 (self.position.x + 0.1f, self.position.y, self.position.z);
		}
	}

}
