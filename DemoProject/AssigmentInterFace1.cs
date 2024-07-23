using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public interface IPlayable
    {
        void Play();
    }
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }


    internal interface AssigmentInterFace1
        {
            static void Main(string[] args)
            {
                // Create instances
                IPlayable videoPlayer = new VideoPlayer();
                IPlayable musicPlayer = new MusicPlayer();

                // Call the play method and observe the output
                videoPlayer.Play(); // Output: Playing video...
                musicPlayer.Play(); // Output: Playing music...
            }
        }

    }

