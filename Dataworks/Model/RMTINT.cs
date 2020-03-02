using System;
using System.Collections.Generic;
using System.Text;

namespace Dataworks.Model
{
    class romtoInt
    {
		public int RomanToInt(string s)
		{
			int result = 0;
			if (String.IsNullOrEmpty(s))
				return result;
			s = s.ToUpper();
			for (var i = 0; i < s.Length; i++)
			{
				switch (s[i])
				{
					case 'I':
						{ //1
							switch (GetLetter(s, i + 1))
							{
								case 'V':
									{
										result += 4;
										i++;
										break;
									}
								case 'X':
									{
										result += 9;
										i++;
										break;
									}
								default:
									result += 1;
									break;
							}

							break;
						}
					case 'V':
						{ //5
							result += 5;
							break;
						}
					case 'X':
						{  //10
							switch (GetLetter(s, i + 1))
							{
								case 'L':
									{
										result += 40;
										i++;
										break;
									}
								case 'C':
									{
										result += 90;
										i++;
										break;
									}
								default:
									result += 10;
									break;
							}
							break;
						}
					case 'L':
						{ //50
							result += 50;
							break;
						}
					case 'C':
						{ //100
							switch (GetLetter(s, i + 1))
							{
								case 'D':
									{
										result += 400;
										i++;
										break;
									}
								case 'M':
									{
										result += 900;
										i++;
										break;
									}
								default:
									result += 100;
									break;
							}
							break;
						}
					case 'D':
						{ //500
							result += 500;
							break;
						}
					case 'M':
						{ //1000
							result += 1000;
							break;
						}
				}

			}
			if (result < 3000)
				return result;
			else return 0;
		}
		private Char? GetLetter(string s, int index)
		{
			if (index >= s.Length)
				return null;

			return s[index];
		}
	}
}
