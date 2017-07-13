using Terraria.ID;
using Terraria.ModLoader;

namespace EvisceratorMKI
{
	class EvisceratorMKI : Mod
	{
		public EvisceratorMKI()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
