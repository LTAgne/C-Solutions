using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        private bool isOn;
        private int currentChannel = 3;
        private int currentVolume = 2;


        /// <summary>
        /// Current on/off status of the tv
        /// </summary>
        public bool IsOn
        {
            get { return isOn; }        
        }

        /// <summary>
        /// Current selected channel number for the tv. Channels are 3 to 18.
        /// </summary>
        public int CurrentChannel
        {
            get { return currentChannel; }            
        }


        /// <summary>
        /// Current volume level for the tv. Volume level ranges from 0 to 10.
        /// </summary>
        public int CurrentVolume
        {
            get { return currentVolume; }            
        }

        /// <summary>
        /// Turns the tv on. Also resets the volume level to 2
        /// </summary>
        public void TurnOn()
        {
            isOn = true;            
            currentVolume = 2;
        }

        /// <summary>
        /// Tuns the tv off.
        /// </summary>
        public void TurnOff()
        {
            isOn = false;
        }

        /// <summary>
        /// Changes the tv channel, but only if it is on.
        /// </summary>
        /// <param name="newChannel">new channel to turn to</param>        
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel > 3 && newChannel < 18)
            {
                currentChannel = newChannel;
            }
        }

        /// <summary>
        /// Increases the Current Channel by 1, only if it is on.
        /// </summary>
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (currentChannel == 18)
                {
                    currentChannel = 3;
                }
                else
                {
                    currentChannel++;
                }                
            }
        }

        /// <summary>
        /// Increases the Current Channel by 1, only if it is on.
        /// </summary>
        public void ChannelDown()
        {
            if (IsOn)
            {
                if (currentChannel == 3)
                {
                    currentChannel = 18;
                }
                else
                {
                    currentChannel--;
                }
            }
        }

        /// <summary>
        /// Raises the volume. It won't raise it past 10
        /// </summary>
        public void RaiseVolume()
        {
            if(IsOn && currentVolume < 10)
            {
                currentVolume++;
            }
        }

        /// <summary>
        /// Lowers the volume. It won't lower it below 0
        /// </summary>
        public void LowerVolume()
        {
            if (IsOn && currentVolume > 0)
            {
                currentVolume--;
            }
        }

    }
}
