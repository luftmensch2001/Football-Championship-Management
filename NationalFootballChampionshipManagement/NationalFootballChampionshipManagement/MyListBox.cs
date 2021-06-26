using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    public sealed class MyListBox : CheckedListBox
    {
        public MyListBox()
        {
            ItemHeight = 25;
        }
        public override int ItemHeight { get; set; }
    }
}
