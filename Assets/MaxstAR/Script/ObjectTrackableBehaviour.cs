/*==============================================================================
Copyright 2017 Maxst, Inc. All Rights Reserved.
==============================================================================*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace maxstAR
{
	public class ObjectTrackableBehaviour : AbstractObjectTrackableBehaviour
	{
        //public Text test2;

        public override void OnTrackSuccess(string id, string name, Matrix4x4 poseMatrix)
		{
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
           
            // canvas set by me to augment UI elements 
            Canvas test1 = GetComponentInChildren<Canvas>(true);

            //Enable canvas
            test1.enabled = true;
           

			// Enable renderers
			foreach (Renderer component in rendererComponents)
			{
				component.enabled = true;
			}

			// Enable colliders
			foreach (Collider component in colliderComponents)
			{
				component.enabled = true;
			}

			transform.position = MatrixUtils.PositionFromMatrix(poseMatrix);
			transform.rotation = MatrixUtils.QuaternionFromMatrix(poseMatrix);
			transform.localScale = MatrixUtils.ScaleFromMatrix(poseMatrix);
		}

		public override void OnTrackFail()
		{
            //GameObject test3 = GameObject.FindGameObjectWithTag("StaticText");
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
           
            Canvas test1 = GetComponentInChildren<Canvas>(true);

            //Diable canvas
            test1.enabled = false;

                       
            // Disable renderer
            foreach (Renderer component in rendererComponents)
			{
				component.enabled = false;
			}

			// Disable collider
			foreach (Collider component in colliderComponents)
			{
				component.enabled = false;
			}

                  

		}
	}
}