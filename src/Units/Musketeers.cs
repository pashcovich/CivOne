// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.Advances;
using CivOne.Attributes;
using CivOne.Enums;
using CivOne.Templates;

namespace CivOne.Units
{
	[Default]
	internal class Musketeers : BaseUnitLand
	{
		public Musketeers() : base(3, 2, 3, 1)
		{
			Type = Unit.Musketeers;
			Name = "Musketeers";
			RequiredTech = new Gunpowder();
			ObsoleteTech = new Conscription();
			SetIcon('A', 0, 0);
		}
	}
}