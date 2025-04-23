using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;
using Unity.FPS.Gameplay;
namespace AG2298

{ 

	public class TargetColorChange : MonoBehaviour
	{
		private Renderer targetRenderer;
		private Color originalColor;
		public Color hitColor = Color.red;
		public float colorChangeDuration = 0.5f;

		private void Start()
		{
			targetRenderer = GetComponent<Renderer>();
			if (targetRenderer != null)
			{
				originalColor = targetRenderer.material.color;
			}
		}

		public void OnShot()
		{
			if (targetRenderer != null)
			{
				StopAllCoroutines();
				StartCoroutine(ChangeColorTemporarily());
			}
		}

		private System.Collections.IEnumerator ChangeColorTemporarily()
		{
			targetRenderer.material.color = hitColor;
			yield return new WaitForSeconds(colorChangeDuration);
			targetRenderer.material.color = originalColor;
		}
	}
}
