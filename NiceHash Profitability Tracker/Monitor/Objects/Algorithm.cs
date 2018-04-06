using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class Algorithm
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public float GetHashMultiplier()
		{
			return (float)Math.Pow(10,DataHelper.DataManager.GetAlgoFloatMultiplierByName(Name));
		}
		public int GetNiceHashID()
		{
			switch (Name)
			{
				case "scrypt":
					return 0;
				case "sha256":
					return 1;
				case "scryptnf":
					return 2;
				case "x11":
					return 3;
				case "x13":
					return 4;
				case "keccak":
					return 5;
				case "x15":
					return 6;
				case "nist5":
					return 7;
				case "neoscrypt":
					return 8;
				case "lyra2re":
					return 9;
				case "whirlpoolx":
					return 10;
				case "qubit":
					return 11;
				case "quark":
					return 12;
				case "axiom":
					return 13;
				case "lyra2rev2":
					return 14;
				case "scryptjanenf16":
					return 15;
				case "blake256r8":
					return 16;
				case "blake256r14":
					return 17;
				case "blake256r8vnl":
					return 18;
				case "hodl":
					return 19;
				case "daggerhashimoto":
					return 20;
				case "decred":
					return 21;
				case "cryptonight":
					return 22;
				case "libry":
					return 23;
				case "equihash":
					return 24;
				case "pascal":
					return 25;
				case "x11gost":
					return 26;
				case "sia":
					return 27;
				case "blake2s":
					return 28;
				case "skunk":
					return 29;
				default:
					return 0;
			}
		}
	}
}
