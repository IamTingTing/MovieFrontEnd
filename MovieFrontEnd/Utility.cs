using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieOrderSystem
{
    internal class SelectedSession
    {
        internal int SelectedSessionID { get; set; }
        internal TimeSpan SelectedPlayTime { get; set; }
        internal string TheaterName { get; set; }

        internal string ShowString()
        {
            string  selectedPlayTime= SelectedPlayTime.ToString().Substring(0, 5);
            return $"{selectedPlayTime} {TheaterName}";
        }
    }

    internal class SeatPosition
    {
        internal int SeatID { get; set; }
        internal int SeatRow { get; set; }
        internal int SeatColumn { get; set; }
    }

    public class CheckedSeatPosition
    {
        internal int SeatID { get; set; }
        internal int SeatRow { get; set; }
        internal int SeatColumn { get; set; }
        public override string ToString()
        {
            return $"第{SeatRow}排 第{SeatColumn}個";
        }
    }

    

}
