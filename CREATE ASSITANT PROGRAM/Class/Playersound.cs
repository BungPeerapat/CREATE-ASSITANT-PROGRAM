using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace CREATE_ASSITANT_PROGRAM.Class
{
    internal class Playersound
    {
        WMPLib.WindowsMediaPlayer Player;
        private void Playsound(string url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.URL = url;
            Player.controls.play();
            Player.settings.setMode("loop", true);
            Player.settings.volume = 5;
        }

        WMPLib.WindowsMediaPlayer STARTSOUNDFIRST;
        public void STARTSOUND1(string url)
        {
            STARTSOUNDFIRST = new WMPLib.WindowsMediaPlayer();
            STARTSOUNDFIRST.URL = url;
            STARTSOUNDFIRST.controls.play();
            STARTSOUNDFIRST.settings.volume = 5;
        }
    }
}
