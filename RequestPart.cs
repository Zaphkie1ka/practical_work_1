using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RequestPart
    {
        private Instruments _instrument;
        private int time;
        private int startTime = 0;

        public RequestPart(Instruments instrument, int time)
        {
            this._instrument = instrument;
            this.time = time;
        }
        public Instruments GetInstrument() { return _instrument; }
        public int GetTime() { return time; }
        public void SetStartTime(int startTime) { this.startTime = startTime; }
        public int GetStartTime() { return startTime; }
    }
}
