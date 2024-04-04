using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GameOffsets;

public struct Pattern
{
	public readonly string Name;

	public readonly byte[] Data;

	public readonly bool[] Mask;

	public readonly int BytesToSkip;

	private static (byte[], bool[]) ParseArrayOfHexBytes(List<string> arrayOfHexBytes)
	{
		List<bool> mask = new List<bool>();
		List<byte> data = new List<byte>();
		for (int i = 0; i < arrayOfHexBytes.Count; i++)
		{
			string hexByte = arrayOfHexBytes[i];
			if (hexByte.StartsWith("?"))
			{
				data.Add(0);
				mask.Add(item: false);
			}
			else
			{
				data.Add(byte.Parse(hexByte, NumberStyles.HexNumber));
				mask.Add(item: true);
			}
		}
		return (data.ToArray(), mask.ToArray());
	}

	public Pattern(string name, string arrayOfHexBytes)
	{
		Name = name;
		List<string> arrayOfHexBytesList = arrayOfHexBytes.Split(new string[2] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
		BytesToSkip = arrayOfHexBytesList.FindIndex("^".Equals);
		(Data, Mask) = ParseArrayOfHexBytes(arrayOfHexBytesList.Where((string hex) => hex != "^").ToList());
	}

	public Pattern(string name, string arrayOfHexBytes, int bytesToSkip)
	{
		Name = name;
		BytesToSkip = bytesToSkip;
		(Data, Mask) = ParseArrayOfHexBytes(arrayOfHexBytes.Split(new string[2] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList());
	}

	public override string ToString()
	{
		string data = "Name: " + Name + " Pattern: ";
		for (int i = 0; i < Data.Length; i++)
		{
			data = ((!Mask[i]) ? (data + "?? ") : (data + $"0x{Data[i]:X} "));
		}
		return data + $"BytesToSkip: {BytesToSkip}";
	}
}
