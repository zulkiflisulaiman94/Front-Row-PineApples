using System;
using NUnit.Framework;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ZulTest
	{
		[Test()]
		public void TestFetchingTheCorrectSound ()
		{
			GameSounds.LoadSounds();

			string _sound1Name = Audio.SoundEffectName(GameSounds._TheGameSound("Click_On"));

			Assert.AreEqual("C:\\DProject\\Front-Row-Pineapples\\bin\\Debug\\Resources\\sounds\\Click_On.wav", _sound1Name);
			GameSounds.FreeSounds ();
		}

		[Test()]
		public void TestDeletingAllTheSounds ()
		{
			GameSounds.FreeSounds ();

			string _sound1Name = Audio.SoundEffectName(GameSounds._TheGameSound("Click_On"));

			Assert.AreNotEqual("C:\\DProject\\Front-Row-Pineapples\\bin\\Debug\\Resources\\sounds\\Click_On.wav", _sound1Name);
			Assert.AreEqual ("", _sound1Name);
		}

	}
}
