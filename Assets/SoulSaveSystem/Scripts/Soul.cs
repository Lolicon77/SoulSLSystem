using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SoulSaveSystem {
	public class Soul : MonoBehaviour {

		internal List<SoulPiece> soulPieces = new List<SoulPiece>();
		private float soulValue = 1.0f;

		internal float SoulValue
		{
			get
			{
				return soulValue;
			}
			set
			{
				soulValue = value;
				if (soulValue > dyingThreshold && soulValue < weakThreshold) {
					OnEnterWeakState();
				} else if (soulValue > weakThreshold) {
					OnEnterNormalState();
				} else if (soulValue > 0) {
					OnEnterDyingState();
				}
			}
		}

		internal int maxPieceCount = 5;
		internal float weakThreshold = 0.4f;
		internal float dyingThreshold = 0.2f;

		public void SplitSoul(Horcrux horcrux, float value) {
			var soulPiece = new SoulPiece {
				@from = this,
				@value = new SoulPieceValue() {
					@valueReciprocal = Mathf.RoundToInt(1 / value)
				}
			};
			horcrux.soulPiece = soulPiece;
			SoulValue -= value;
		}

		public void ReclaimSoulPiece(Horcrux horcrux) {
			throw new NotImplementedException();
		}

		public virtual void OnEnterWeakState() {

		}

		public virtual void OnEnterDyingState() {

		}

		public virtual void OnEnterNormalState() {

		}

	}
}