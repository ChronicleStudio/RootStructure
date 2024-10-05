using Newtonsoft.Json;

namespace WorldGenDecoder
{
	internal class Program
	{
		static int Main(string[] args)
		{
			int errorCode = 0;
			if (args.Length < 3) { Console.Error.WriteLine("Invalid Arguments, Arguments needed: \"Action: [Encode|Decode]\" \"InputPath: string\" \"OutputPath: string\""); errorCode = errorCode | 0x00000001; }
			if (args.Length < 1 || !(args[0]?.ToLower() == "encode" || args[0]?.ToLower() == "decode" || args[0]?.ToLower() == "e" || args[0]?.ToLower() == "d")) { Console.Error.WriteLine("Action Invalid: Value expected: [Encode|Decode]/[E|D]"); errorCode = errorCode | 0x00000010; }
			if (args.Length < 2) { Console.Error.WriteLine("Invalid Path, path needs to be specified."); errorCode = errorCode | 0x00000100; Console.Error.WriteLine($"Fatel error detected, Program exiting with code 0x{Convert.ToString(errorCode, 16).PadLeft(8, '0')}"); return errorCode; }
			string path = args[1];
			if (!File.Exists(path) && File.Exists(path + ".json"))
			{
				path += ".json";
			}

			if (!File.Exists(path))
			{
				Console.Error.WriteLine("Can't import " + path + ", it does not exist");
				errorCode = errorCode | 0x00000200;
			}
			if (errorCode != 0) { Console.Error.WriteLine($"Fatel error detected, Program exiting with code 0x{Convert.ToString(errorCode, 16).PadLeft(8, '0')}"); return errorCode; };

			return errorCode;
		}
		public static int Decode(string inPath, string outPath)
		{


			Console.WriteLine("Hello, World!");
			try
			{
				dynamic? array;
				using (TextReader reader = new StreamReader(inPath))
				{
					array = JsonConvert.DeserializeObject(reader.ReadToEnd());
					reader.Close();
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine(e.Message);
			}
			return 0;
		}
		public static int Encode(string inPath, string outPath)
		{
			return 0;
		}
	}
}
