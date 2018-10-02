using MvcApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Color
{
    public class ColorVm
    {
        private int _colorCount;
        private List<ProColor> _colorList;

        private string _selectedcolorcode;
        private string _selectedcolor;


        public ColorVm()
        {


        }

        public string SelectedColorName
        {
            get
            {
                return _selectedcolor;
            }
            set
            {
                _selectedcolor = value;
            }
        }

        public int ColorCount
        {
            get
            {
                return _colorCount;
            }
            set
            {
                _colorCount = value;
            }
        }

        public List<ProColor> ColorList
        {
            get
            {
                return _colorList;
            }
            set
            {
                _colorList = value;
            }
        }

        public string SelectedColorCode
        {
            set
            {
                _selectedcolorcode = value;
            }
            get
            {
                return _selectedcolorcode;
            }
        }
    }
}