using System;
using SwinGameSDK;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace MyGame
{
	public static class GameSounds
	{
		private static Dictionary<string, SoundEffect> _Sounds = new Dictionary<string, SoundEffect>();

		public static void LoadSounds()
		{
			NewSound("Click_On", "Click_On.wav");
			NewSound("Button", "Button.wav");
			NewSound("Ta_Da", "Ta_Da.wav");
			NewSound("Kids_Cheering", "Kids_Cheering.wav");
			NewSound("Computer_Error", "Computer_Error.wav");
			NewSound("Lose", "lose.wav");
		}

		public static SoundEffect _TheGameSound(string sound)
		{
			if(_Sounds.Count != 0)
				return _Sounds[sound];

			return null;
		}

		private static void NewSound(string soundName, string filename)
		{
			_Sounds.Add(soundName, Audio.LoadSoundEffect(SwinGame.PathToResource(filename, ResourceKind.SoundResource)));
		}

		public static void FreeSounds()
		{
			foreach (SoundEffect obj in _Sounds.Values)
			{
				Audio.FreeSoundEffect (obj);
			}
		}

	}
}

