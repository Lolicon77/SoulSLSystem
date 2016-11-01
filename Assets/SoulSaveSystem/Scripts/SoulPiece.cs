namespace SoulSaveSystem {

	public class SoulPiece {
		internal Soul from;
		internal SoulPieceValue value;
	}

	class SoulPieceValue {
		internal int valueReciprocal;
		private float value;

		internal float Value
		{
			get
			{
				return value;
			}
		}
	}
}