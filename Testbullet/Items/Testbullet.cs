using Terraria.ModLoader;

namespace Testbullet
{
	class Testbullet : Mod
	{
		public Testbullet()
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
