using System;
using System.IO;
using System.Media;

namespace HOUSE.House
{
    internal static class Sounds
    {
        private static SoundPlayer _currentPlayer; // holds reference for StopSound

        /// <summary>
        /// Plays a WAV sound file.
        /// </summary>
        /// <param name="path">Full or relative path to the .wav file</param>
        /// <param name="loop">Play repeatedly until stopped</param>
        /// <param name="block">Wait until sound finishes before continuing</param>
        public static void PlaySound(string path, bool loop = false, bool block = false)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[Sound Error] File not found: {path}");
                    Console.ResetColor();
                    return;
                }

                _currentPlayer = new SoundPlayer(path);

                if (loop)
                    _currentPlayer.PlayLooping();
                else if (block)
                    _currentPlayer.PlaySync();
                else
                    _currentPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[Sound Error] {ex.Message}");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Stops the last looping sound played by PlaySound().
        /// </summary>
        public static void StopSound()
        {
            try
            {
                _currentPlayer?.Stop();
            }
            catch
            {
                // Intentionally ignore — stop failures shouldn't crash the game
            }
        }
    }
}