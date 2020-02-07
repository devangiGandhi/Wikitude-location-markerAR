/*==============================================================================
Copyright 2017 Maxst, Inc. All Rights Reserved.
==============================================================================*/

using UnityEngine;
using System.IO;
using JsonFx.Json;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using UnityEngine.Rendering;

namespace maxstAR
{
    public class InstantTrackableBehaviour : AbstractInstantTrackableBehaviour
    {
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