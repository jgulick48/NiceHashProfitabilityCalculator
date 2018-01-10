using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.Objects
{
	public class Algorithm
	{
		public int ID;
		public string Name;
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
					break;
				case "sha256":
					return 1;
					break;
				case "scryptnf":
					return 2;
					break;
				case "x11":
					return 3;
					break;
				case "x13":
					return 4;
					break;
				case "keccak":
					return 5;
					break;
				case "x15":
					return 6;
					break;
				case "nist5":
					return 7;
					break;
				case "neoscrypt":
					return 8;
					break;
				case "lyra2re":
					return 9;
					break;
				case "whirlpoolx":
					return 10;
					break;
				case "qubit":
					return 11;
					break;
				case "quark":
					return 12;
					break;
				case "axiom":
					return 13;
					break;
				case "lyra2rev2":
					return 14;
					break;
				case "scryptjanenf16":
					return 15;
					break;
				case "blake256r8":
					return 16;
					break;
				case "blake256r14":
					return 17;
					break;
				case "blake256r8vnl":
					return 18;
					break;
				case "hodl":
					return 19;
					break;
				case "daggerhashimoto":
					return 20;
					break;
				case "decred":
					return 21;
					break;
				case "cryptonight":
					return 22;
					break;
				case "libry":
					return 23;
					break;
				case "equihash":
					return 24;
					break;
				case "pascal":
					return 25;
					break;
				case "x11gost":
					return 26;
					break;
				case "sia":
					return 27;
					break;
				case "blake2s":
					return 28;
					break;
				case "skunk":
					return 29;
					break;
				default:
					return 0;
			}
		}
	}
}
