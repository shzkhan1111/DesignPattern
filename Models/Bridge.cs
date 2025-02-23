using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    #region remote
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }
    }

    //advance remote has one more feature
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }

    #endregion

    #region Devices
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChannel(int channel);
    }
    public class Tv : IDevice
    {
        private bool isEnabled;
        private int volume = 50;
        private int channel = 1;

        public bool IsEnabled() => isEnabled;
        public void Enable() => isEnabled = true;
        public void Disable() => isEnabled = false;
        public int GetVolume() => volume;
        public void SetVolume(int percent) => volume = percent;
        public int GetChannel() => channel;
        public void SetChannel(int channel) => this.channel = channel;
    }

    public class Radio : IDevice
    {
        private bool isEnabled;
        private int volume = 50;
        private int channel = 1;

        public bool IsEnabled() => isEnabled;
        public void Enable() => isEnabled = true;
        public void Disable() => isEnabled = false;
        public int GetVolume() => volume;
        public void SetVolume(int percent) => volume = percent;
        public int GetChannel() => channel;
        public void SetChannel(int channel) => this.channel = channel;
    }
    #endregion
}
