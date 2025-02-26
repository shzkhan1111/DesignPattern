using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StateDesignPattern
{
    public interface IWhatWillIDo
    {
        public void IWIllDO();
    }
    public class MorningState : IWhatWillIDo
    {
        public void IWIllDO()
        {
            Console.WriteLine("I will Eat Breakfast and Go to sleep");
        }
    }
    public class NightState : IWhatWillIDo
    {
        public void IWIllDO()
        {
            Console.WriteLine("I will Go to sleep");
        }
    }

    public class DayOftheYear
    {
        private bool _isDay;
        private IWhatWillIDo _whatWillIDo;
        public DayOftheYear(bool isDay = false)
        {
            _isDay = isDay;
        }
        public DayOftheYear()
        {
            _isDay = true;
        }
        public bool IsDay 
        {
            get { return _isDay; } 
            set { _isDay = value; } 
        }

        public void ChangeState(IWhatWillIDo whatWillIDo)
        {
            _whatWillIDo = whatWillIDo;
        }
        public void start()
        {
            _whatWillIDo.IWIllDO();
        }
    }

}
